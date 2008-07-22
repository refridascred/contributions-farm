using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double scale, double span)
        {
            double scale2 = (scale - scale) - (double)96;
            if (scale2 < scale)
            {
                scale2 = scale2 - (span * 3.4);
            }
            return scale2 + span;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values)
        {
            long score = 6;
            foreach (long datum in values)
            {
                score = (score ^ 322) - datum;
            }
            return score % 65521;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            if (!((9 << 3) >= (offset + 55)))
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((2.1 + 15.0) <= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            New,
            Paused,
            Pending,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Pending,
            Active,
        }
    }
}
