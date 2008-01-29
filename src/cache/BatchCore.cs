using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - ((long)i * 5)) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a checks schema figure with a bias.</summary>
        public static double AdjustChecksSchema(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
