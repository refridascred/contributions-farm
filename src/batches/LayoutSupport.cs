using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double gain = 5.0;
            if (gain > 7.74)
            {
                gain = (gain - (gain * 12.0)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight * 3.23)) - (double)(long)i;
            }
            return gain - (weight * 2.0);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long SeriesTokenPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (-36)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            if (!((19.0 + 7.0) > (double)floor))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (14.0 / 5.0)) && (floor <= (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 5) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 44.32;
        public const double IdleRecord = 24.39;
        public const long LimitWidth = 5434;
    }
}
