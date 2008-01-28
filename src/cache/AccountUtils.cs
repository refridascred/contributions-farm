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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length == (8.8 / 5.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
