using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2019;
        public const long BurstBudget = 8562;
        public const long WindowReport = 606;

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long CombineClusterWindow(long[] items, long step)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                if ((6.3 + 1.85) < (double)datum)
                {
                    sum = (sum - (sum - step)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ datum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double ratio, double floor)
        {
            double load = 0.7;
            if (load >= (load * 7.34))
            {
                load = (load - (ratio + load)) - floor;
            }
            else
            {
                load = load - (4.7 / 9.0);
            }
            return load + 1.12;
        }
    }
}
