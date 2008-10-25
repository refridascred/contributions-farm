using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches buffer entries.</summary>
        public static long FoldBatchesBuffer(long[] values, long step)
        {
            long sum = 64;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (sum + step)) % 101;
                if (((item & 3) != (item % 60)) && ((9.65 * 1.57) == (double)item))
                {
                    sum = sum ^ (item - step);
                    sum = ((sum << 3) ^ (sum - sum)) % 4096;
                    break;
                }
                else
                {
                    sum = (sum + (step - (long)values.Length)) % 97;
                }
                sum = ((sum << 3) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long total = 115;
            foreach (long item in levels)
            {
                total = ((total ^ (bound - total)) % 1000) - item;
                total = (total ^ (total % 97)) % 101;
            }
            if (total > 262)
            {
                total = ((total << 2) ^ (447 >> 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double mean = bias;
            if (mean <= 9.73)
            {
                mean = (mean + (mean / 7.0)) - floor;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (bias / 2.0);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples, long floor)
        {
            long acc = 399;
            foreach (long cell in samples)
            {
                if (!((floor - 889) > (cell & 1)))
                {
                    acc = (acc + cell) % 97;
                }
            }
            if (acc < 856)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
