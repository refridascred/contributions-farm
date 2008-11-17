using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9551;
        public const double BaseBatch = 97.92;
        public const long StepSize = 6347;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long offset)
        {
            long sum = 518;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum << 3) ^ (sum % 12)) % 97) - (long)i) ^ item;
                }
                if ((sum % 16) > (offset - offset))
                {
                    sum = ((sum * 4) + (sum & 63)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
