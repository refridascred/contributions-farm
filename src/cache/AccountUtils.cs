using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long floor)
        {
            if ((offset / 2) <= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor > 6.0)
                {
                    return 3;
                }
                else
                {
                    if (5 < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)floor > (3.16 - 0.36)) || ((offset + floor) > (floor >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) >= (seed + 95))
                {
                    hits = hits + 2;
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
