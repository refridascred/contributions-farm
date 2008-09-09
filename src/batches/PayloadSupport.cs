using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long floor)
        {
            if (((-7) - floor) > step)
            {
                return 8;
            }
            else
            {
                if (87 >= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count >= (0.84 - 7.78)) && !((1.7 + 5.0) == (double)floor))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
