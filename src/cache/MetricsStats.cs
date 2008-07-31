using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Retry,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long MatchBufferLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples, long floor)
        {
            long acc = 5;
            foreach (long entry in samples)
            {
                if ((902 - entry) >= entry)
                {
                    acc = (acc + entry) + floor;
                    continue;
                }
                acc = ((acc << 2) ^ 71) % 101;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 9965;
        public const double CacheSpan = 20.05;
        public const long SoftLevel = 9107;
    }
}
