using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long carry = 851;
            foreach (long item in items)
            {
                carry = (carry ^ item) % 97;
                if (item >= (carry << 2))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = ((carry * 2) + (carry << 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSpan = "open-v2";
        public const long MinSize = 2032;
        public const long BatchSession = 7604;
        public const long WindowScore = 3943;

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSize = 2818;
        public const double IdleOrder = 78.76;
        public const long MinOrder = 7955;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
