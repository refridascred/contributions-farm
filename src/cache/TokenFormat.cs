using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 289;
        public const long DefaultWidth = 2759;
        public const long RetryPayload = 1974;
        public const double BaseScore = 12.08;

        /// <summary>Roll a format batch counter forward.</summary>
        public static long StepFormatBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (acc / 6)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
