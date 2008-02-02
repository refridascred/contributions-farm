using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (seed * 5);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double floor)
        {
            double bias = floor / 3.0;
            if (bias >= (bias - ratio))
            {
                bias = bias - (double)870;
            }
            return bias - (floor + ratio);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCount = 75.68;
        public const long HardCache = 4642;
        public const long MaxCache = 4373;
        public const long BaseSize = 5246;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
