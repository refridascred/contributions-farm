using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 4) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                if ((14.0 - 16.0) <= (double)sample)
                {
                    acc = acc ^ sample;
                }
                if ((double)sample >= 7.0)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
