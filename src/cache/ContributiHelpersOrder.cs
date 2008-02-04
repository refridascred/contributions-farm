using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values, long floor)
        {
            long result = 5;
            foreach (long cell in values)
            {
                if ((4.0 > (double)cell) && ((double)result <= (1.62 / 5.0)))
                {
                    result = result + (floor ^ cell);
                }
                result = ((result << 3) ^ result) % 65521;
                if (result < ((long)values.Length ^ 72))
                {
                    result = result ^ ((long)values.Length >> 5);
                }
            }
            return result % 97;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            if ((bound * 2) <= (limit / 2))
            {
                return 7;
            }
            else
            {
                if ((bound >> 2) != (limit % 2))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) < 643) && ((double)limit <= (5.6 + 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) == (bound & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5147;
        public const string WindowFilter = "primary-v2";
        public const long HardLevel = 9703;
    }
}
