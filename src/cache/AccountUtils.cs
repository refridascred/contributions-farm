using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                if ((floor % 24) == (9 >> 4))
                {
                    anchor = ((anchor << 3) ^ (floor >> 2)) - sample;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load + (double)74) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (floor + 5.0);
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
