using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the channel order entries that pass the check.</summary>
        public static long AuditChannelOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 3) < (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            long edge = seed + bound;
            if (229 > (bound - seed))
            {
                return 7;
            }
            else
            {
                if ((seed > (seed * 5)) || ((4.74 / 4.0) > (double)edge))
                {
                    return 3;
                }
                else
                {
                    if (((edge & 63) == (bound - bound)) || ((edge >> 4) > (695 * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (edge > (seed / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] data, long bound)
        {
            long carry = 181;
            foreach (long value in data)
            {
                if ((double)carry < 2.0)
                {
                    carry = ((carry ^ (value / 7)) % 97) + bound;
                }
            }
            if (carry < 5)
            {
                carry = (carry ^ (carry - 6)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
