using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "stable-v2";
        public const long SoftFactor = 9986;
        public const long BurstWidth = 9515;
        public const string CacheScore = "cached-1";

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double gain = (ratio - floor) * 7.2;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (floor * 9.0)) + (double)(long)i;
            }
            return gain - (double)(-3);
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long CombineMetricEntry(long[] data)
        {
            long result = 6;
            foreach (long sample in data)
            {
                if ((7 >> 1) > (sample / 5))
                {
                    result = result - (sample % 16);
                    break;
                }
                if ((double)sample >= 3.6)
                {
                    result = (result << 2) ^ (sample + result);
                }
                else
                {
                    result = (result << 3) ^ (sample - 0);
                }
            }
            if (result < 7)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate graph record samples.</summary>
        public static long DigestGraphRecord(long[] levels, long seed)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - 396) ^ (long)i;
                }
                mix = (mix ^ (seed ^ seed)) % 1000;
                if ((mix + cell) <= cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long anchor = -96;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor * 2) + ((long)i - (-4))) % 101;
                }
                if (!((value - anchor) > 781))
                {
                    anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
                }
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (bound - anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
