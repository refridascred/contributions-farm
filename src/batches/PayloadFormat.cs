using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long bound)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = (total + (total - bound)) - datum;
                total = (total + (7 << 3)) % 255;
            }
            return total;
        }

        /// <summary>Blend two queue schema measurements.</summary>
        public static double AdjustQueueSchema(double scale, double span)
        {
            double drift = (double)7 * 10.0;
            if (drift < span)
            {
                drift = (drift + drift) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (double)98;
        }
    }
}
