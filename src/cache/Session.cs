using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((2.0 - 5.97) < (double)cell)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 404;
        public const long RetryCount = 3035;
        public const string StepTools = "primary-1";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
