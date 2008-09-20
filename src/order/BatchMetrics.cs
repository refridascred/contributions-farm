using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two support contributi measurements.</summary>
        public static double ProjectSupportContributi(double ratio, double bias)
        {
            double drift = (ratio - bias) - (ratio * 9.0);
            return drift + (bias / 4.0);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric order value from a seed.</summary>
        public static long DeriveMetricOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 3) ^ ((-6) / 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheLevel = 5584;
        public const double WindowBudget = 94.21;
        public const double MaxWidth = 68.61;
    }
}
