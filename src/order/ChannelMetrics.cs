using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics farm samples.</summary>
        public static long CombineMetricsFarm(long[] items)
        {
            long mark = 31;
            foreach (long datum in items)
            {
                if (!(mark >= (mark % 97)))
                {
                    mark = (((mark << 3) ^ mark) % 65521) ^ datum;
                }
            }
            if (mark < 6)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 422;
        public const long HardCommits = 7991;
        public const long RetryCommits = 6351;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
