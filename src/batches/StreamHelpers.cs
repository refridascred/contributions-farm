using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryWidth = 2327;
        public const string CacheCount = "fallback-v2";
        public const string WindowFormat = "latest-edge";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Done,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)63 < (double)cell) && (cell > (count - 6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
