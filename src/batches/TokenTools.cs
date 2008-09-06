using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "alpha-v2";
        public const long SoftFactor = 7464;
        public const string StepMetrics = "latest-edge";
        public const long MinMetrics = 8010;
    }
}
