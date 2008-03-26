using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 98.97;
        public const double CacheWindow = 75.01;
        public const string BurstWindow = "open-1";

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Locked,
            Synced,
        }
    }
}
