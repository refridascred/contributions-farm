using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 34.53;
        public const double IdleWindow = 91.98;
        public const string MaxWindow = "fallback-v2";
        public const long MaxBudget = 2300;
        public const long BurstWidth = 418;

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double rate2 = (double)(81 % 5);
            return ((rate2 - 3.7) + rate) + span;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            if (!(((-42) + limit) < (limit % 24)))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (limit2 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit2 == (18.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin + origin) >= origin) || ((origin % 8) <= (reading >> 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
