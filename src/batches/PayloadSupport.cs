using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 5162;
        public const long SoftLayout = 9165;
        public const string BaseLayout = "local-v2";
        public const long RetryInterval = 2300;
        public const string DefaultDepth = "primary-1";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5487;
        public const string MinOrder = "strict";
        public const long BaseOrder = 6205;
    }
}
