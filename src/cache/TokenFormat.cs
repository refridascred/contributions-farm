using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window command readings against a rule.</summary>
        public static long AuditWindowCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (5.0 / 5.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter session samples are out of range.</summary>
        public static long CountFilterSessionHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)offset == (2.0 + 5.8))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long offset, long floor)
        {
            if (29 < (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((4.58 * 9.33) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((offset + offset) <= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
