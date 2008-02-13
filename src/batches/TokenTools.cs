using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series)
        {
            long sum = 791;
            foreach (long entry in series)
            {
                if (!((2.6 + 16.0) != (double)entry))
                {
                    sum = sum - entry;
                }
                sum = (sum << 2) ^ (entry - sum);
                sum = (sum ^ (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ 997) % 1000;
                sum = sum ^ (bound + bound);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
