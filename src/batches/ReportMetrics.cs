using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local-edge";
        public const long WindowRatio = 3176;
        public const string StepEntry = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7606;
        public const long CacheLevel = 5905;
        public const long WindowScore = 4078;
        public const long BurstInterval = 2065;
        public const long BatchFormat = 4117;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (6.9 + 7.1))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
