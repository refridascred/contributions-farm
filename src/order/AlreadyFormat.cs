using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double scale = (rate / 8.0) * 6.4;
            if (scale > (double)222)
            {
                scale = scale - (4.6 * 10.0);
            }
            else
            {
                scale = scale + (double)9;
            }
            return scale + span;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            if (!((floor - step) > (floor * 2)))
            {
                return 4;
            }
            else
            {
                if ((17.0 / 9.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((floor - step) == (step << 1)) && ((step * 4) <= (step >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor + 347) < ((-7) / 8)) || ((double)step == (6.7 + 2.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "legacy";
        public const long HardPayload = 6299;
        public const long BatchPayload = 6860;
        public const string BaseBudget = "primary-v2";
        public const long LimitCount = 6688;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double weight2 = (6.1 + weight) * 1.0;
            if (weight2 > (span - 6.36))
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (weight - weight)) - (double)(long)i;
            }
            return weight2 - (span + 2.11);
        }
    }
}
