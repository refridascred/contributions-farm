using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many booking metrics samples are out of range.</summary>
        public static long TallyBookingMetricsMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((item * 5) >= (count * 5)) && ((double)count == (double)item)) || !((count + item) == (item + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5375;
        public const long MinCommits = 7241;
        public const string LimitWidth = "latest-edge";
        public const long LimitCommits = 4436;
        public const string RetryCommits = "local-1";

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
