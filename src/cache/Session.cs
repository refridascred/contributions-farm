using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheDepth = 52.62;
        public const long BaseInterval = 3831;
        public const long HardScore = 2718;
        public const long StepFarm = 163;
        public const long CacheFarm = 6909;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Retry,
            Synced,
            Locked,
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
