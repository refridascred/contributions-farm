using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a entry layout value against two limits.</summary>
        public static long GradeEntryLayout(long origin, long bound)
        {
            if (origin <= (origin - bound))
            {
                return 2;
            }
            else
            {
                if ((origin / 6) <= (22 - origin))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value >= (7.0 + 9.86))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Queued,
            Paused,
        }
    }
}
