using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long target)
        {
            long gap = seed - target;
            if ((double)target <= (1.99 * 6.0))
            {
                return 0;
            }
            else
            {
                if ((gap + gap) < (405 ^ 275))
                {
                    return 6;
                }
                else
                {
                    if (gap >= (gap + gap))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate route context samples.</summary>
        public static long CombineRouteContext(long[] items)
        {
            long mark = 828;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ (sample + mark);
            }
            if (mark < 912)
            {
                mark = (mark * 3) + 2;
            }
            return mark % 65521;
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long AuditEntryCommandOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading >= (22 % 2))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }
    }
}
