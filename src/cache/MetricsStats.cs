using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 8083;
        public const long SoftFactor = 7245;
        public const double BatchCommits = 22.9;
        public const double StepSpan = 83.55;
        public const long BurstCommits = 2515;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Roll a record route counter forward.</summary>
        public static long DeriveRecordRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((6.0 + 2.0) < (double)acc)
                {
                    continue;
                }
                else
                {
                    long tally = acc >> 2;
                    acc = (acc - tally) % 255;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - (acc >> 2)) % 97) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 24.82;
        public const double MinSession = 54.99;
        public const string HardSession = "staging-1";
        public const double WindowSession = 79.04;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleDepth = 7920;
        public const long CacheSession = 3265;
        public const long HardScore = 7046;
    }
}
