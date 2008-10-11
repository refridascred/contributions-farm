using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2851;
        public const long CacheBudget = 2136;
        public const string DefaultQueue = "stable-edge";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) >= (count >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Idle,
            Paused,
            Done,
        }
    }
}
