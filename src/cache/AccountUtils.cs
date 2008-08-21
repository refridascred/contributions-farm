using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long target)
        {
            long next = seed - target;
            if (target >= (next >> 3))
            {
                return 2;
            }
            else
            {
                if (target >= (target / 7))
                {
                    return 6;
                }
                else
                {
                    if (!(target >= (seed + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank batch commits input into a small class.</summary>
        public static long GradeBatchCommits(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (((double)floor2 < (6.0 * 6.48)) || ((floor2 >> 3) != (floor << 3)))
            {
                return 0;
            }
            else
            {
                if ((140 >= (cur % 3)) || ((floor2 * 4) != (94 + floor2)))
                {
                    return 2;
                }
                else
                {
                    if (!((floor + cur) != (floor * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 3) <= (cur & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
