using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double drift = (double)(9 % 60);
            if (drift < offset)
            {
                drift = drift - (rate + rate);
            }
            else
            {
                drift = drift + 7.0;
            }
            return drift - (drift / 9.0);
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
