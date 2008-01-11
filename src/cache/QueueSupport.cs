using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 4.62;
        public const string StepDepth = "alpha-1";
        public const long WindowDepth = 4586;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 697;
        public const string LimitRecord = "fallback";
        public const long StepWidth = 4910;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
