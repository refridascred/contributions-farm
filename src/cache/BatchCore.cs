using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long score = 849;
            foreach (long value in data)
            {
                score = (score - (value / 7)) % 4096;
            }
            if (score > (-73))
            {
                score = (score * 5) + limit;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long SortSupportOrder(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound >= 3.1)
            {
                return 7;
            }
            else
            {
                if ((bound % 10) != (bound - offset2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long origin)
        {
            if (((double)origin <= (5.0 - 0.54)) || ((1.0 * 14.0) >= (4.47 + 5.39)))
            {
                return 0;
            }
            else
            {
                if (16.0 > (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
