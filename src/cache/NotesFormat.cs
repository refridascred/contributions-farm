using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long carry = -320;
            foreach (long sample in data)
            {
                carry = ((carry ^ 70) + sample) + origin;
            }
            if (carry < 293)
            {
                carry = ((carry * 3) + (carry % 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 14.48;
        public const long RetrySpan = 1961;
        public const double MinScore = 88.2;
        public const string CacheContext = "strict-v2";
    }
}
