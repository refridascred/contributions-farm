using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstLevel = "primary-edge";
        public const string MinTools = "fallback-v2";
        public const long RetrySize = 2651;
        public const long MaxRatio = 2406;
        public const string LimitScore = "cached";

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 6367;
        public const long RetryChecks = 7884;
        public const string CacheSpan = "alpha";
        public const double BatchCount = 25.47;
        public const long StepChecks = 6777;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long origin)
        {
            long carry = 69;
            foreach (long entry in data)
            {
                if (origin >= (540 + carry))
                {
                    carry = carry ^ (entry + entry);
                }
            }
            return carry % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 1515;
        public const long StepSpan = 3317;
        public const long LimitLayout = 3079;
        public const string IdleTimeout = "staging";
        public const string HardLayout = "cached";
    }
}
