using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long origin)
        {
            if (!((9.0 * 4.76) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (5.8 - 9.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of commits tools readings.</summary>
        public static long OverlapCommitsToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long bound)
        {
            long acc = -9;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ (acc ^ (long)series.Length)) % 1000) - sample;
                acc = acc ^ (bound & 1);
            }
            return acc % 65521;
        }
    }
}
