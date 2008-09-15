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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
