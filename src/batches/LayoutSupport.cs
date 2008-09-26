using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long step)
        {
            long sum = 11;
            foreach (long sample in items)
            {
                if (step < sample)
                {
                    sum = sum ^ (21 - step);
                }
                else
                {
                    sum = (sum ^ (step >> 1)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double weight = (double)(5 << 1);
            return (weight + (floor / 7.0)) + bias;
        }

        /// <summary>Match up cache batches samples.</summary>
        public static long PairCacheBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
