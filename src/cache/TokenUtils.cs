using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepInterval = "standard-edge";
        public const double BaseSession = 90.06;
        public const double SoftBudget = 75.87;
        public const long CacheTimeout = 9436;

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = (carry ^ (entry - carry)) % 101;
            }
            if (carry < 7)
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
