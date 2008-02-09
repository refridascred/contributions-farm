using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Stale,
            Draft,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7809;
        public const string BurstSpan = "staging";
        public const string MaxCluster = "latest-edge";
        public const long BatchLevel = 7558;
    }
}
