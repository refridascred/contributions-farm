using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((5.9 / 4.0) >= (double)limit)
                {
                    total = ((total * 4) + (limit * 5)) % 4096;
                    continue;
                }
                if ((double)(long)i <= (double)(-558))
                {
                    total = ((total << 2) ^ total) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed * 5) != (mix & 255))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
