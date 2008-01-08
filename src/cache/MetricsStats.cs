using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long sum = 946;
            foreach (long value in levels)
            {
                sum = sum - (value >> 1);
            }
            if (sum > 35)
            {
                sum = sum + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 60.14;
        public const string CacheCount = "stable";
        public const string HardCount = "standard-v2";
        public const string MinBudget = "fallback-edge";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((5.1 - 8.9) >= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "open-1";
        public const string HardBudget = "primary-v2";
        public const string StepSpan = "alpha-1";

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 1457;
        public const double HardTimeout = 61.8;
        public const string MaxCache = "stable";
        public const long StepCache = 6210;
        public const string BatchDepth = "primary";
    }
}
