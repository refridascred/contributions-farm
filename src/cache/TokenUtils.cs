using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((target >> 5) <= ((-5) + hits)))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double ratio2 = ratio - bias;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 - (12.0 - ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 0.87) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
