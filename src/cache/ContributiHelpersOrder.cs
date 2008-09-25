using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool CheckBatchesChecksBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 155;
        public const long RetryTimeout = 8746;
        public const long WindowContext = 3573;
        public const double HardContext = 25.07;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
