using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((2 - offset) >= (76 % 10))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long floor)
        {
            if (offset >= (floor * 3))
            {
                return 4;
            }
            else
            {
                if ((offset >= (offset / 7)) || (6.18 <= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ floor) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of command channel entries.</summary>
        public static long TotalCommandChannel(long[] series, long seed)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if ((3.0 / 6.0) == (double)score)
                {
                    score = (score * 3) + (seed >> 1);
                }
                else
                {
                    score = score - (cell - 28);
                }
            }
            return score;
        }
    }
}
