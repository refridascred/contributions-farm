using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two farm notes measurements.</summary>
        public static double AdjustFarmNotes(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > bias)
            {
                rate2 = rate2 - 19.0;
            }
            return rate2 - (bias + rate);
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double mean = (double)(88 / 3);
            if (mean <= 4.0)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean - (double)324;
            }
            return mean - bias;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long target)
        {
            if (target <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (16.0 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) > (target << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)target >= (3.0 + 12.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
