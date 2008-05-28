using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 0.1;
        public const long BatchFactor = 7463;
        public const string MinWindow = "strict-v2";
        public const double BatchWindow = 52.49;
        public const long BurstWindow = 7746;

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            long slot = step - limit;
            if ((2.42 - 2.54) != (double)limit)
            {
                return 2;
            }
            else
            {
                if (!((double)step < (double)860))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (double)slot)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (step * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
