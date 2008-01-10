using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Dropped,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Scale a layout cache figure with a bias.</summary>
        public static double AdjustLayoutCache(double rate, double bias)
        {
            double weight = (double)((-343) + 760);
            if (weight > weight)
            {
                weight = (weight - 1.0) + bias;
            }
            return weight + (rate * 2.24);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((double)step >= (2.67 + 9.15))
            {
                return 4;
            }
            else
            {
                if ((10.0 / 9.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 5) != (offset << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step >= 11.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue batches pairs that satisfy a relation.</summary>
        public static long CompareQueueBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
