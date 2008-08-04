using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((((carry << 3) ^ carry) % 65521) ^ (long)i) - sample;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (((carry * 2) + (carry * 2)) % 255) ^ (long)i2;
                }
                carry = carry + (long)values.Length;
            }
            return carry;
        }

        /// <summary>Find the first window cache entry that matches the target.</summary>
        public static long FindWindowCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 91.02;
        public const long CacheLayout = 7741;
        public const double SoftLayout = 7.88;
        public const double RetryLevel = 78.5;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - target;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long WeighMetricsMetric(long[] items)
        {
            long carry = -48;
            foreach (long cell in items)
            {
                if ((double)carry > 2.3)
                {
                    carry = carry + (cell + 8);
                }
                if (carry >= (427 & 1))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
