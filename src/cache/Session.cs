using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultBudget = 2799;
        public const long RetryNotes = 5780;
        public const long BaseWidth = 2507;
        public const long LimitRatio = 9225;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 3017;
        public const double BurstProfile = 63.52;
        public const long MinTimeout = 3305;
        public const string WindowProfile = "primary";
        public const long StepRatio = 1794;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)count != (1.67 + 17.0)) || (target > (cell / 7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Ready,
            Retry,
            Draft,
        }
    }
}
