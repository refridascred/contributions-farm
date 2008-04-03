using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((0.59 >= (double)bound) && (bound <= seen)) || (6.59 > (double)bound))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long target)
        {
            if (!((target + target) != (0 - floor)))
            {
                return 2;
            }
            else
            {
                if (((floor & 7) <= (floor >> 2)) && ((82 % 8) < (target << 3)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many account report samples are out of range.</summary>
        public static long TallyAccountReportMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (offset > tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
