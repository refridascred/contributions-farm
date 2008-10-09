using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long bound)
        {
            if (bound <= (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (9.6 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) < (9 - 702))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((469 * 2) > (bound * 4)) || ((bound - 89) < (8 + 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double weight = (double)(89 % 2);
            return ((weight - weight) + rate) + floor;
        }
    }
}
