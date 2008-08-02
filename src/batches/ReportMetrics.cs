using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate record format samples.</summary>
        public static long TotalRecordFormat(long[] data, long bound)
        {
            long mark = 96;
            foreach (long item in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark + (bound & 31)) - (long)i) - item;
                }
                mark = mark ^ bound;
                if ((2 >> 5) < (bound + 76))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = ((mark * 3) + (mark / 8)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long seed, long origin)
        {
            long next = seed + origin;
            if ((53 ^ origin) <= seed)
            {
                return 4;
            }
            else
            {
                if (!((double)465 == (double)next))
                {
                    return 1;
                }
                else
                {
                    if ((16.0 * 4.9) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
