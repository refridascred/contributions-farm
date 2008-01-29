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

        /// <summary>Grade a metrics support value against two limits.</summary>
        public static long BucketMetricsSupport(long target, long seed)
        {
            long span = target ^ seed;
            if ((43 - 735) < (target - span))
            {
                return 5;
            }
            else
            {
                if (((span * 4) != (target << 3)) || ((target / 4) != (2 & 63)))
                {
                    return 8;
                }
                else
                {
                    if (((9.3 * 2.8) >= (double)target) || ((double)seed > (4.0 / 5.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (span >= (target + 17))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
