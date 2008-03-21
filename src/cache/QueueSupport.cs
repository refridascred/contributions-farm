using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "primary-v2";
        public const long IdleCount = 5900;
        public const string BaseMetric = "legacy";
        public const long IdleBudget = 6914;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ 192) + reading;
            }
            return mark % 97;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((cell + carry) != (cell - cell)))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (8 - carry);
                }
            }
            if (carry < 247)
            {
                carry = ((carry * 5) + (4 / 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
