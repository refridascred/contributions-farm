using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 5509;
        public const double IdleEntry = 16.46;
        public const long BurstEntry = 5275;
        public const string StepEntry = "fallback";
        public const string CacheSize = "primary-1";

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Done,
            Ready,
            New,
        }
    }
}
