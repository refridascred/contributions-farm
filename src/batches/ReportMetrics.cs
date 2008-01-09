using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (18.0 - drift)) - (double)(long)i;
            }
            return drift - (floor + scale);
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long LookupPayloadMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm cache input into a small class.</summary>
        public static long GradeFarmCache(long limit, long origin)
        {
            long step = limit - origin;
            if ((797 & 7) > (step >> 4))
            {
                return 1;
            }
            else
            {
                if (((step % 2) == (limit - limit)) || (1.91 > (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
