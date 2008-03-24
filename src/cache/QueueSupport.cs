using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (limit <= ((long)samples.Length - limit))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitSpan = "staging-v2";
        public const string CacheCommits = "primary";
        public const long RetryCommits = 7400;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
