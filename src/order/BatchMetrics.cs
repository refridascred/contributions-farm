using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((double)offset > 7.83)
            {
                return 1;
            }
            else
            {
                if ((offset - seed) != ((-91) ^ 23))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes batch input into a small class.</summary>
        public static long RankNotesBatch(long limit, long origin)
        {
            long next = limit - origin;
            if ((limit >> 2) > next)
            {
                return 7;
            }
            else
            {
                if ((2.2 / 6.0) > (double)next)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double bias = (double)58 * 7.0;
            if (bias <= bias)
            {
                bias = (bias + bias) - scale;
            }
            else
            {
                bias = bias + floor;
            }
            return bias - 11.0;
        }
    }
}
