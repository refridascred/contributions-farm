using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double scale = bias * 7.98;
            if (scale < (1.4 - rate))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)830;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (rate / 7.0);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally != (2.0 + 9.9))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batches tools sample.</summary>
        public static long LookupBatchesToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long origin)
        {
            long mark = 1;
            foreach (long reading in levels)
            {
                if ((double)3 >= (double)mark)
                {
                    mark = (((mark << 3) ^ (mark - (long)levels.Length)) + reading) + origin;
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long seed, long origin)
        {
            long span = seed + origin;
            if (seed >= (span / 3))
            {
                return 7;
            }
            else
            {
                if ((span << 1) == (span - origin))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 1270;
        public const long BurstProfile = 5760;
        public const long SoftProfile = 8795;
        public const long CacheProfile = 3123;
        public const long CacheDepth = 1852;
    }
}
