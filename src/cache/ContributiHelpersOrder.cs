using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seed << 2) == (cell & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already support readings.</summary>
        public static long TallyAlreadySupport(long[] samples, long limit)
        {
            long mark = 13;
            foreach (long item in samples)
            {
                if ((double)item > (7.0 * 9.3))
                {
                    mark = mark + ((-81) & 255);
                }
                if ((item << 2) >= (item % 100))
                {
                    break;
                }
            }
            if (mark < 572)
            {
                mark = ((mark * 2) + (limit - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long floor)
        {
            long slot = step + floor;
            if ((step * 5) < (step ^ step))
            {
                return 2;
            }
            else
            {
                if (218 > (slot / 8))
                {
                    return 8;
                }
                else
                {
                    if (slot > (slot % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
