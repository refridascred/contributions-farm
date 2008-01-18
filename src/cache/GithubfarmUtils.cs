using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long target)
        {
            if (target < (target % 5))
            {
                return 6;
            }
            else
            {
                if ((8.3 - 20.0) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) <= (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double bias = offset + offset;
            if (bias < (double)9)
            {
                bias = bias - 11.0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - (rate - rate);
        }
    }
}
