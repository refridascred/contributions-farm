using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string DefaultTimeout = "cached-1";
        public const long HardCount = 4501;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 2054;
        public const long SoftMetrics = 7746;
        public const string BurstMetrics = "fallback-edge";
        public const long IdleMetrics = 6563;

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (gain - 4.45);
            }
            else
            {
                rate = rate + (gain / 3.0);
            }
            return rate + gain;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((243 + count) >= sample) || !(bound >= 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) > 4)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
