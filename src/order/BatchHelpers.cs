using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long floor)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 7) == (result + reading))
                {
                    result = ((result << 3) ^ (floor ^ reading)) % 255;
                }
                if (!((result >> 2) > reading))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 63;
            foreach (long datum in series)
            {
                if ((double)datum < (double)79)
                {
                    mark = (mark * 5) + (datum / 8);
                }
                else
                {
                    mark = mark - (mark << 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
