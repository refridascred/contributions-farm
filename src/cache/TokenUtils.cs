using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 448;
        public const long MinBudget = 3178;
        public const long WindowFactor = 9051;
        public const long MaxSize = 7740;
        public const string LimitCommand = "local-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitCount = 1911;
        public const long IdleLayout = 1472;
        public const double BaseLevel = 73.5;

        /// <summary>Accumulate tools route samples.</summary>
        public static long DigestToolsRoute(long[] samples, long step)
        {
            long carry = 544;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ (step >> 1)) - reading;
            }
            if (carry > 344)
            {
                carry = (carry - (step + step)) % 1000;
            }
            return carry;
        }
    }
}
