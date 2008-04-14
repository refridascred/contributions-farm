using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long ClassifyContextRoute(long floor, long offset)
        {
            if ((2.4 - 6.2) < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((floor % 60) == (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset >= (6.88 * 0.77)) && ((double)offset <= (4.05 * 5.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset * 4) < (offset >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
