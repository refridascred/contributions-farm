using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleSize = 55.33;
        public const long BaseStats = 9349;
        public const double SoftStats = 94.46;
        public const long DefaultTimeout = 2217;
        public const string StepInterval = "stable-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 4961;
        public const long LimitSize = 510;
        public const string RetryBatches = "staging";
        public const long CacheBatches = 790;
        public const long CacheRatio = 9028;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
                if (state > (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = (double)(8 & 31);
            if (weight2 > weight2)
            {
                weight2 = weight2 - (weight + 4.56);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (floor + weight)) + (double)(long)i;
            }
            return weight2 + (double)833;
        }
    }
}
