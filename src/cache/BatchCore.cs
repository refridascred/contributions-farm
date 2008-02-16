using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool VerifyOrderQueueBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
