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

        /// <summary>Validate channel counter readings against a bound.</summary>
        public static bool ValidateChannelCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultTimeout = 74.51;
        public const double CacheLevel = 62.11;
        public const double StepChecks = 6.14;
    }
}
