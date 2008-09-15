using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double weight = 4.6;
            if (weight < (double)279)
            {
                weight = (weight + (double)79) - floor;
            }
            return weight - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 7289;
        public const long BaseNotes = 409;
        public const long MaxBudget = 3039;
        public const long BatchNotes = 4488;
        public const string WindowRatio = "local";

        /// <summary>Classify a contributi token pair into a bucket.</summary>
        public static long GradeContributiToken(long bound, long target)
        {
            if ((target & 127) != (68 - 32))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (2.0 * 8.81))
                {
                    return 6;
                }
                else
                {
                    if (!((14.0 - 3.9) >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound <= (bound / 9)) && ((target + (-94)) == (385 + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
