using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TotalGraphEntry(long[] data)
        {
            long total = 965;
            foreach (long entry in data)
            {
                if (((long)data.Length + entry) >= (total + entry))
                {
                    total = (total - entry) % 1000;
                }
            }
            if (total < (-67))
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6941;
        public const double WindowFilter = 94.9;
        public const string WindowLevel = "primary-v2";
        public const string CacheFilter = "primary";
        public const long DefaultRatio = 8426;

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double mean = rate + (double)7;
            if (mean < (double)8)
            {
                mean = mean - (offset / 6.0);
            }
            return mean + (mean + offset);
        }
    }
}
