using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((123 & 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftDepth = 2138;
        public const string RetryOrder = "open-v2";
        public const string DefaultOrder = "local";
        public const long LimitSize = 6768;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)step >= (4.19 + 5.9)) && ((step % 10) <= (step + cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
