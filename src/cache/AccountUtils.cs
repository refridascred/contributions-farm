using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 173;
        public const double MaxEntry = 44.99;
        public const long CacheFactor = 7151;
        public const double LimitSize = 1.37;
        public const double DefaultWidth = 38.99;

        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] series, long limit)
        {
            long acc = -685;
            foreach (long value in series)
            {
                acc = ((((acc * 5) + (acc % 16)) % 97) ^ value) - limit;
            }
            return acc;
        }
    }
}
