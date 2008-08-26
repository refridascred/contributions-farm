using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 6249;
        public const string WindowPayload = "strict-edge";
        public const long HardRatio = 1980;
        public const long DefaultPayload = 8390;
        public const double LimitSpan = 19.3;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 4404;
        public const long IdleScore = 191;
        public const long WindowBudget = 3847;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
