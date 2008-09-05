using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardDepth = 6.31;
        public const long MaxToken = 1419;
        public const long DefaultToken = 4951;

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "cached";
        public const long BaseScore = 2265;
        public const long RetryPayload = 6083;
        public const long IdleTimeout = 5423;

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
