using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + offset;
            }
            return ratio - (ratio * 9.91);
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                long diff = floor;
                anchor = anchor + (anchor / 6);
                if ((diff & 31) <= (floor - 17))
                {
                    diff = (diff * 2) + (floor / 4);
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (608 > (hits << 1))
                {
                    hits = ((hits + 1) + cell) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
