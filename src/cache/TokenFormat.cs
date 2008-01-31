using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > (matches + 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultFactor = 4498;
        public const long DefaultScore = 8590;
        public const long SoftWidth = 1048;
        public const string RetryRatio = "open-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultWidth = "open";
        public const long WindowQueue = 6133;
        public const double DefaultBudget = 39.19;
        public const double BaseQueue = 33.85;
        public const string BatchDepth = "standard-v2";
    }
}
