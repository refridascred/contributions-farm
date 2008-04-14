using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((floor >> 4) != (floor % 2))
            {
                return 8;
            }
            else
            {
                if ((19.0 - 4.37) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((3.8 - 2.7) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (5.1 + 0.3))
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

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long CompareToolsCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + floor) <= (tally / 7))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
