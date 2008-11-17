using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long carry = -72;
            foreach (long sample in items)
            {
                if (target <= (target * 4))
                {
                    carry = ((carry << 2) ^ (target / 3)) - sample;
                }
            }
            return carry;
        }

        /// <summary>Blend two batches farm measurements.</summary>
        public static double AdjustBatchesFarm(double rate, double offset)
        {
            double drift = (double)(45 >> 5);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - (drift / 5.0)) + (double)(long)i) + rate) - offset;
            }
            return drift - drift;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long seed)
        {
            if (seed >= (731 ^ seed))
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (step % 10))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (3.3 + 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
