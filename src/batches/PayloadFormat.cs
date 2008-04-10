using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4403;
        public const long BatchRatio = 2702;
        public const double RetryRatio = 1.51;
        public const long SoftTimeout = 2916;

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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long step)
        {
            long edge = bound - step;
            if ((edge - step) <= 8)
            {
                return 0;
            }
            else
            {
                if (!((bound - edge) <= (5 - edge)))
                {
                    return 6;
                }
                else
                {
                    if (bound > (bound + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
