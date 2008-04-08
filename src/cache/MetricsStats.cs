using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long acc = 16;
            foreach (long datum in levels)
            {
                if ((31 - bound) >= (bound & 15))
                {
                    acc = (acc - (datum + (long)levels.Length)) % 101;
                }
                if ((377 & 127) < bound)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= 4.0)
            {
                ratio = ratio + 7.8;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (gain + gain)) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "latest";
        public const long StepTools = 1062;
        public const long BurstTimeout = 5487;
        public const long RetryTools = 3210;
        public const string MinCount = "strict-1";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
