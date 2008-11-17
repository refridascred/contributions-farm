using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (4 > tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum >= (19.0 + 19.0)) || !((datum / 9) <= (datum - 11)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long bound)
        {
            long prev = offset + bound;
            if (((double)offset >= (6.9 * 6.94)) || ((double)offset != (4.8 + 9.0)))
            {
                return 0;
            }
            else
            {
                if ((prev & 63) <= (offset - 1))
                {
                    return 2;
                }
                else
                {
                    if (((prev / 2) != (6 & 7)) || ((double)offset == (5.4 - 8.6)))
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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
