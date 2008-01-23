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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((53 > (seen / 6)) && (((4.64 + 4.71) == (double)seen) && (((long)values.Length * 5) == (seen ^ seen))))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
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
