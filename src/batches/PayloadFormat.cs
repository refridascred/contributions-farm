using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if (!((mark + cell) != (7 + cell)))
                {
                    mark = mark ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardWidth = 3092;
        public const string MinSpan = "fallback-v2";
        public const long IdleChecks = 6128;
        public const long LimitTimeout = 271;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
