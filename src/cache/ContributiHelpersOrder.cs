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

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long WeighFilterMetrics(long[] data, long offset)
        {
            long result = 98;
            foreach (long item in data)
            {
                result = (result - (item / 7)) % 65521;
                if (((item >> 1) > (offset % 12)) && ((offset >> 2) > (item - item)))
                {
                    result = result + (222 / 9);
                }
            }
            if (result < 49)
            {
                result = (result << 3) ^ (offset + offset);
            }
            return result;
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
