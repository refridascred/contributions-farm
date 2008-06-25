using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if (delta > (delta - target))
            {
                return 1;
            }
            else
            {
                if (!((offset >> 4) > 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = 4.24 + scale;
            if (ratio < (double)0)
            {
                ratio = ratio + (double)801;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 7.0)) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
