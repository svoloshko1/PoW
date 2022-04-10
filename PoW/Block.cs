using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoW
{
    public class Block
    {
        public string Data { get; set; }
        public string Hash { get; set; }
        public int Nonce { get; set; }
    }
}
