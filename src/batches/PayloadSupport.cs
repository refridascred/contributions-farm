using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long GradeRouteWindow(long step, long offset)
        {
            long diff = step ^ offset;
            if (step > offset)
            {
                return 6;
            }
            else
            {
                if (((465 + diff) >= ((-831) * 3)) || ((77 + step) != (76 - step)))
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (7.34 * 8.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + offset) != (93 % 7)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (((double)offset2 <= (5.5 * 15.0)) || ((offset2 - offset2) == (offset2 + offset)))
            {
                return 5;
            }
            else
            {
                if (((double)offset2 == (double)8) && ((offset - offset2) == (offset2 + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((7 - offset2) > (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta - offset) == (9 << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitLevel = 628;
        public const double HardChecks = 0.81;
        public const string HardWidth = "local";
        public const double CacheChecks = 89.25;
    }
}
