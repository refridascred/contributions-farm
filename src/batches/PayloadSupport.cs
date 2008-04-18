using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((5 + hits) <= (value + 8)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long seed)
        {
            long mark = 67;
            foreach (long item in samples)
            {
                if ((item << 1) >= mark)
                {
                    mark = (mark ^ (mark + item)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] values)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                if (((double)sum >= 2.63) && ((sum << 1) != (sample + sample)))
                {
                    sum = sum ^ (sample - sample);
                }
                if ((9.8 * 15.0) != (double)sample)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
