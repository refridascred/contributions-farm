using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry - (sample + 65)) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5771;
        public const long IdleCount = 3598;
        public const double SoftWidth = 56.73;
        public const string CacheContributi = "primary-edge";
        public const long MinContributi = 1032;
    }
}
