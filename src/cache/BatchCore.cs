using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double drift = 4.4;
            if (drift > bias)
            {
                drift = (drift - (double)9) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - 11.0)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Pending,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long offset)
        {
            if (!(offset <= 68))
            {
                return 2;
            }
            else
            {
                if (!((limit << 1) >= (limit % 60)))
                {
                    return 6;
                }
                else
                {
                    if (!(limit > (22 ^ 18)))
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
    }
}
