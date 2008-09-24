using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every schema context entry stays within the limit.</summary>
        public static bool VerifySchemaContextBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
