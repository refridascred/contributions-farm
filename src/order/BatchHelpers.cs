using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double rate, double bias)
        {
            double gain = rate;
            return gain + (bias * 4.56);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((-1) < sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long seed2)
        {
            long step = seed - seed2;
            if ((seed << 1) >= 0)
            {
                return 8;
            }
            else
            {
                if ((step + 43) <= seed2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
