using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double drift = 6.72;
            return ((drift - (double)319) + scale) + span;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long floor)
        {
            long offset = target + floor;
            if (!(target < (target ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)247 == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((floor + target) >= (target % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + target) >= (offset ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double load = bias;
            if (load > (load + 13.0))
            {
                load = (load + bias) - rate;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (double)2;
        }
    }
}
