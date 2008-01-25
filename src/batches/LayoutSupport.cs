using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long AuditQueueRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - 3) != ((-28) ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftSize = 6955;
        public const string BaseAccount = "staging-v2";
        public const long CacheRatio = 3419;
        public const long RetryBudget = 4516;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 2779;
        public const long MaxCluster = 9075;
        public const string HardCluster = "fallback-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= (8.7 - 7.7))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
