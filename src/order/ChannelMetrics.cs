using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long SoftRoute = 4657;
        public const double LimitRatio = 0.97;
        public const long HardLevel = 4781;
        public const long WindowRoute = 7669;

        /// <summary>Audit profile queue readings against a rule.</summary>
        public static long CountProfileQueueOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (7.0 / 9.0)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
