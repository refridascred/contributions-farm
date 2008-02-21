using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double rate = gain * 16.0;
            if (rate > (gain - offset))
            {
                rate = rate + (double)7;
            }
            return rate - offset;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double ScaleLayoutStats(double scale, double floor)
        {
            double load = (double)58 / 8.0;
            if (load > (double)(-7))
            {
                load = (load + load) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (6.2 / 7.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if (mark >= (sample % 8))
                {
                    mark = mark - (mark >> 2);
                }
                if ((sample / 9) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5721;
        public const long HardEntry = 9346;
        public const double MinDepth = 75.46;
        public const string DefaultEntry = "fallback-edge";
    }
}
