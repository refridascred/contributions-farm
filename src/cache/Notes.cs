using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultTimeout = 74.51;
        public const double CacheLevel = 62.11;
        public const double StepChecks = 6.14;
    }
}
