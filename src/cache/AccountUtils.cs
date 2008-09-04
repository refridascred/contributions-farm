using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 6631;
        public const string RetryCounter = "fallback-edge";
        public const long MinTimeout = 4790;
        public const string WindowSpan = "standard-edge";
        public const long MaxScore = 291;

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] data)
        {
            long acc = 4;
            foreach (long item in data)
            {
                if ((double)acc < (4.0 + 0.62))
                {
                    acc = ((acc * 5) + item) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Active,
        }
    }
}
