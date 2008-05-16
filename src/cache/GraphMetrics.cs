using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two graph batch measurements.</summary>
        public static double SmoothGraphBatch(double scale, double offset)
        {
            double gain = (double)930 / 3.0;
            if (gain > (offset / 5.0))
            {
                gain = (gain + offset) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long BucketGraphPayload(long bound, long step)
        {
            long edge = bound - step;
            if (!((step & 127) > (81 + 392)))
            {
                return 2;
            }
            else
            {
                if ((double)edge >= (double)5)
                {
                    return 1;
                }
                else
                {
                    if (!(step <= (step & 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 0;
            foreach (long value in readings)
            {
                long next = (value + step) ^ (8 >> 4);
                if ((7.44 + 6.2) > (double)step)
                {
                    total = ((total * 2) + (next + step)) % 97;
                }
                if ((value << 3) > 408)
                {
                    total = (total + (903 / 6)) % 101;
                }
            }
            if (total > 3)
            {
                total = (total - (step + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCount = "fallback";
        public const long RetryTimeout = 5831;
        public const long DefaultSize = 9453;
        public const string SoftFactor = "fallback-1";
    }
}
