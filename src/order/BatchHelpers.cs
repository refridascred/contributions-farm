using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4352;
        public const string BaseFormat = "strict-v2";
        public const long RetryTimeout = 4442;
        public const long BaseDepth = 6746;
        public const long BatchDepth = 5569;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Active,
        }
    }
}
