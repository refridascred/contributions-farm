using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long floor)
        {
            if ((double)floor > (2.6 / 5.0))
            {
                return 8;
            }
            else
            {
                if (((floor + origin) == (origin + origin)) && ((3.0 - 3.0) <= (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ floor) != (floor << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits % 8) == (hits >> 3))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
