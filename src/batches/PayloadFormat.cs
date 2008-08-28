using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings, long offset)
        {
            long total = 25;
            foreach (long reading in readings)
            {
                if (((offset / 8) >= total) || ((2.7 + 16.0) > (double)reading))
                {
                    total = total + reading;
                }
            }
            return total;
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long WeighClusterSupport(long[] levels)
        {
            long acc = 809;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc - reading) % 65521) - (long)i;
                }
                if (((double)acc <= (double)reading) && ((acc / 3) > (reading / 3)))
                {
                    acc = (acc + (reading / 3)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + 30;
                }
            }
            if (acc > 33)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 77.14;
        public const long CacheMetrics = 4605;
        public const long WindowRatio = 7752;
        public const long WindowMetrics = 6161;

        /// <summary>Validate channel schema readings against a bound.</summary>
        public static bool VerifyChannelSchemaRange(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
