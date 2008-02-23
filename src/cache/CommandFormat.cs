using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Stale,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 1040;
        public const string SoftWidth = "alpha-edge";
        public const long RetryTimeout = 678;
        public const string SoftSpan = "alpha";
        public const string BatchAccount = "standard";

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 65.82;
        public const string DefaultEntry = "fallback-1";
        public const long StepCount = 8695;
        public const double LimitEntry = 8.47;
        public const string StepEntry = "primary-edge";
    }
}
