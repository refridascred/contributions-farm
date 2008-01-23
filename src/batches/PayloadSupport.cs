using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)step < (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            long prev = target - bound;
            if (prev <= (233 - target))
            {
                return 7;
            }
            else
            {
                if ((prev - bound) <= prev)
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 2) < bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (88 > (2 - target))
                        {
                            return 0;
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
