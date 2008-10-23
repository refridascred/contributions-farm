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

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Failed,
            New,
        }

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
