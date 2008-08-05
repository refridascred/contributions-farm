using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank counter schema input into a small class.</summary>
        public static long BucketCounterSchema(long step, long target)
        {
            if ((target + target) != (target & 255))
            {
                return 6;
            }
            else
            {
                if ((target >> 5) == (step / 7))
                {
                    return 1;
                }
                else
                {
                    if (!((target / 3) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step <= (double)22) && ((9.3 / 8.0) == (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Roll a notes stats counter forward.</summary>
        public static long SeriesNotesStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
