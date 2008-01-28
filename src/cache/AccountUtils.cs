using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxWidth = 5889;
        public const string IdleProfile = "cached-1";
        public const string MinBudget = "fallback";
        public const string DefaultProfile = "stable-v2";
        public const long RetryProfile = 6492;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Closed,
            Done,
        }

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
