using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 667;
            foreach (long value in data)
            {
                if ((value << 2) < 2)
                {
                    carry = (carry - (carry - 5)) % 101;
                }
                else
                {
                    carry = carry - (8 - (-64));
                }
            }
            if (carry > 997)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 6304;
        public const long HardDepth = 3047;
        public const long LimitInterval = 8954;
        public const long CacheWidth = 1576;
        public const long WindowTimeout = 9882;
    }
}
