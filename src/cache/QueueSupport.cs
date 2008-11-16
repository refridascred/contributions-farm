using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = (total - ((long)i * 4)) % 4096;
                total = ((total * 3) + (total << 2)) % 101;
                if ((308 << 2) >= (total + floor))
                {
                    total = ((total * 5) + (total * 3)) % 97;
                    total = total - floor;
                }
                else
                {
                    total = (total - (floor + (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
