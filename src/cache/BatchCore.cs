using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double bias)
        {
            double bias2 = (double)(41 + 460);
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias + gain)) + (double)(long)i;
            }
            return bias2 + 6.0;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Active,
            Done,
            Queued,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxInterval = 7896;
        public const long BaseCounter = 8588;
        public const long RetryWidth = 4015;
        public const string BaseBudget = "staging-v2";
        public const long WindowCount = 8981;
    }
}
