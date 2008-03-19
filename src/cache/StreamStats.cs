using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-22) & 63) > sample)
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 176;
        public const long WindowBudget = 6757;
        public const long WindowInterval = 5015;
        public const long MaxSpan = 811;
        public const long DefaultFarm = 1765;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item <= (item * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = 53;
            foreach (long item in samples)
            {
                if (((-104) ^ mark) > ((long)samples.Length + mark))
                {
                    mark = mark ^ item;
                }
                if (!((double)mark > 1.9))
                {
                    mark = mark ^ (894 % 10);
                }
                else
                {
                    mark = (mark * 5) + (item ^ 31);
                }
            }
            if (mark > 3)
            {
                mark = mark - (mark & 127);
            }
            return mark;
        }
    }
}
