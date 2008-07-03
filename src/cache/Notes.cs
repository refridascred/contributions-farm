using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 8903;
        public const long BurstTimeout = 4221;
        public const double RetryLevel = 90.94;
        public const double IdleBatches = 34.26;

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] items, long floor)
        {
            long mix = 930;
            foreach (long reading in items)
            {
                if (((long)items.Length / 6) == (32 >> 5))
                {
                    mix = mix ^ (floor >> 5);
                }
                else
                {
                    mix = (mix - (reading + floor)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long offset)
        {
            if (19.0 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset >= (seed + seed)) && ((offset + offset) != (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
