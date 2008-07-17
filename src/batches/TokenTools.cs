using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double rate2 = (double)700 / 5.0;
            if (rate2 >= (13.0 - 5.83))
            {
                rate2 = (rate2 + (bias + bias)) - rate;
            }
            return rate2 + 5.99;
        }

        /// <summary>Rank channel notes input into a small class.</summary>
        public static long ClassifyChannelNotes(long floor, long bound)
        {
            long delta = floor ^ bound;
            if ((floor & 15) < (36 & 7))
            {
                return 2;
            }
            else
            {
                if ((bound << 1) != (90 + floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor / 8) < (30 * 4)) || ((double)floor == (double)delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - bound) > (-6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
