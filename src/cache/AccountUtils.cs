using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 6760;
        public const long LimitSupport = 8349;
        public const string BurstWidth = "standard-v2";
        public const string CacheSupport = "local-v2";
        public const long WindowSupport = 1171;
    }
}
