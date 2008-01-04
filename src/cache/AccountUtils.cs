using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a format queue reading.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double load = (double)(1 % 7);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (floor * 9.68)) + (double)(long)i) + scale;
            }
            return load - (load + floor);
        }
    }
}
