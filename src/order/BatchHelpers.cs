using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ (anchor + sample)) % 65521;
            }
            if (anchor > 34)
            {
                anchor = (anchor - 8) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] values, long seed)
        {
            long carry = 7;
            foreach (long value in values)
            {
                if ((carry + carry) == (1 ^ seed))
                {
                    carry = ((carry - 29) % 255) - value;
                }
                else
                {
                    carry = (carry ^ (carry / 3)) % 65521;
                }
            }
            if (carry < 5)
            {
                carry = carry + seed;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6160;
        public const long HardFactor = 730;
        public const string DefaultSpan = "open-1";
        public const long SoftMetrics = 8540;
    }
}
