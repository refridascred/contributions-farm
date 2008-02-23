using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardInterval = "fallback-edge";
        public const string WindowGithubfarm = "staging-1";
        public const double IdleScore = 61.77;
        public const double MaxSize = 45.57;
        public const long MaxLevel = 776;

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double scale = (double)((-174) << 1);
            if (scale < scale)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (gain / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 18.0) + (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                if (!((carry * 4) <= (686 % 100)))
                {
                    carry = (carry ^ (7 + limit)) % 4096;
                }
                else
                {
                    carry = (carry + (limit - datum)) % 1000;
                }
            }
            if (carry > (-1))
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
