using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double ratio2 = (double)(26 + 3);
            if (ratio2 <= (double)(-594))
            {
                ratio2 = ratio2 + (bias + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 0.3)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Retry,
            Idle,
            Failed,
        }
    }
}
