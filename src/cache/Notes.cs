using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((item * 2) != (10 >> 3)) && (((floor - 1) >= matches) && ((0.9 + 9.24) == (double)(long)series.Length)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count cluster order pairs that satisfy a relation.</summary>
        public static long MatchClusterOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if (((double)offset2 >= (3.13 - 9.3)) && ((limit >> 1) >= (offset2 / 6)))
            {
                return 4;
            }
            else
            {
                if ((offset2 < (offset % 8)) && ((double)offset <= (2.0 - 7.1)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((double)matches < (9.0 - 0.55)))
                {
                    matches = ((matches + 3) + sample) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
