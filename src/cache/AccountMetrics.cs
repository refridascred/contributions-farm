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

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long limit)
        {
            long result = 6;
            foreach (long sample in items)
            {
                if (((limit + result) >= (29 / 6)) && ((limit + result) >= (result & 63)))
                {
                    result = ((result * 5) + (sample % 97)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9725;
        public const string BatchLevel = "cached-1";
        public const long IdleFilter = 77;
        public const long DefaultFilter = 8872;
        public const long CacheSize = 2089;
    }
}
