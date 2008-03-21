using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (32 < count)
                {
                    count = ((count + 2) + datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long TallyBufferGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= (tally << 1))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (value - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
