using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Idle,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 28.06;
        public const double CacheTimeout = 71.83;
        public const long WindowMetric = 6410;
        public const long StepWidth = 5954;
        public const long MaxRatio = 3662;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long step)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!((81 & 31) > sum))
                {
                    sum = (sum ^ step) % 101;
                    continue;
                }
                if ((50 >> 5) >= (step >> 1))
                {
                    sum = sum ^ (item >> 2);
                }
            }
            if (sum < 85)
            {
                sum = ((sum << 2) ^ (step - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "fallback-edge";
        public const long BurstBatches = 5315;
        public const string RetryBatches = "open-1";

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
