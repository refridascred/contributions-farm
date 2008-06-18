using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 1691;
        public const long BaseDepth = 199;
        public const long MaxRoute = 1941;
        public const long WindowSpan = 4110;
        public const long BaseRoute = 8813;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 6628;
        public const string BurstLevel = "alpha-edge";
        public const long StepSize = 5576;
    }
}
