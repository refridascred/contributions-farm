using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftInterval = 0.85;
        public const long DefaultOrder = 9969;
        public const long HardSize = 5035;
        public const long WindowInterval = 6744;
        public const long HardOrder = 8068;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5211;
        public const long IdleToken = 4038;
        public const long HardScore = 902;
        public const string MinSpan = "fallback-v2";
    }
}
