using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxCount = "latest-edge";
        public const long LimitScore = 2012;
        public const long MinInterval = 3108;
        public const long IdleInterval = 1038;
        public const string SoftSession = "legacy-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchCount = 14.1;
        public const double DefaultAccount = 3.98;
        public const double CacheAccount = 39.74;
        public const long BurstAccount = 8004;
        public const long RetrySize = 8597;

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (631 - offset);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long AuditMetricFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < 6.9)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
