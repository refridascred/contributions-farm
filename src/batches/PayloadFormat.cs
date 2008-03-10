using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepTimeout = "primary-v2";
        public const long SoftBudget = 1895;
        public const long RetryWidth = 8442;
        public const double BurstRatio = 67.96;
        public const long BurstRecord = 7708;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleDepth = 5875;
        public const long SoftReport = 2379;
        public const long BatchReport = 6912;
    }
}
