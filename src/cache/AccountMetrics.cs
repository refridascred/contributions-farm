using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double offset)
        {
            double weight = gain;
            if (weight < 4.5)
            {
                weight = weight - (offset + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (20.0 + gain);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 >= 9.88)
            {
                gain2 = (gain2 - (1.71 + floor)) - gain;
            }
            else
            {
                gain2 = gain2 - (double)35;
            }
            return gain2 - 6.8;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels, long target)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = (mark + (datum ^ mark)) + target;
                if (((mark >> 5) > mark) && ((double)mark > (6.9 - 3.52)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9725;
        public const string BatchLevel = "cached-1";
        public const long IdleFilter = 77;
        public const long DefaultFilter = 8872;
        public const long CacheSize = 2089;
    }
}
