using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((716 < (offset + tally)) || (sample < (tally / 8))) && ((tally * 3) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long step)
        {
            long prev = bound + step;
            if (((5.86 * 8.6) == (double)step) && (prev > step))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > (0.26 + 8.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] levels, long origin)
        {
            long carry = -6;
            foreach (long reading in levels)
            {
                carry = ((((carry << 2) ^ 802) % 4096) + reading) - origin;
            }
            return carry % 65521;
        }
    }
}
