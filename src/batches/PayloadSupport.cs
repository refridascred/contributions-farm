using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((count << 3) <= (cell - count)) && ((double)count < (double)cell)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev / 9) < (origin - 7))
            {
                return 7;
            }
            else
            {
                if (!(origin >= (origin >> 5)))
                {
                    return 6;
                }
                else
                {
                    if ((origin >> 2) < 6)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
