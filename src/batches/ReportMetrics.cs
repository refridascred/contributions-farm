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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
