using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const long RetrySize = 9862;
        public const double StepSize = 88.77;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
