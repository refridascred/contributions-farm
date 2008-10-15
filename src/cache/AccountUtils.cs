using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = mark + origin;
                mark = ((mark * 2) + value) % 1000;
            }
            if (mark > 68)
            {
                mark = mark ^ (long)series.Length;
            }
            return mark % 1000;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if (!((lane + bound) < bound2))
            {
                return 2;
            }
            else
            {
                if (bound < (8 * 2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
