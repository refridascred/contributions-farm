using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheSpan = 88.73;
        public const long BatchWidth = 6610;
        public const long MaxWindow = 1963;
        public const long MinWindow = 4379;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((77 + cell) > (4 >> 5)) || ((double)cell < (15.0 + 0.3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5544;
        public const long SoftPayload = 2685;
        public const long HardPayload = 4080;
        public const string RetryPayload = "stable-v2";
    }
}
