using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (floor <= (value + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4855;
        public const long StepBudget = 6618;
        public const long StepCounter = 2013;
        public const long DefaultCounter = 5169;
        public const long BaseSpan = 3510;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 6203;
        public const string BurstSize = "cached-1";
        public const long LimitScore = 6075;
        public const long CacheContext = 5463;
    }
}
