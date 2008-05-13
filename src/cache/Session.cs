using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1506;
        public const long MaxFactor = 314;
        public const double StepQueue = 13.14;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data, long bound)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = ((acc - (bound / 4)) % 4096) ^ value;
            }
            return acc % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
