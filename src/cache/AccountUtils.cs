using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double load = rate;
            if (load > bias)
            {
                load = load + (double)832;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias / 8.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Locate a metrics contributi reading by value.</summary>
        public static long SeekMetricsContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
