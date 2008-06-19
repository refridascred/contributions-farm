using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinScore = 7389;
        public const string LimitTools = "stable-edge";
        public const double DefaultTools = 94.55;
        public const string RetryTools = "local-edge";
        public const long MaxBudget = 1620;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2388;
        public const long IdlePayload = 1450;
        public const long WindowRatio = 7245;
        public const string SoftPayload = "fallback-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((seed - seed) == (seed & 31))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
