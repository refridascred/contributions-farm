using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long offset)
        {
            if (((offset - 38) == (offset + offset)) || ((double)offset == (1.2 + 0.1)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 63;
            foreach (long datum in levels)
            {
                total = (total * 2) + (datum - 467);
                if (8 < (total ^ datum))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long acc = 90;
            foreach (long value in data)
            {
                acc = ((acc - (acc - acc)) % 65521) ^ value;
            }
            if (acc < 805)
            {
                acc = (acc + (acc << 3)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double floor)
        {
            double bias = gain;
            if (bias < 8.06)
            {
                bias = bias - (bias + floor);
            }
            return bias + gain;
        }
    }
}
