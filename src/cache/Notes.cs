using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Active,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 2486;
        public const double BurstGraph = 62.25;
        public const long MinFactor = 1421;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Closed,
            Active,
            Synced,
            New,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
