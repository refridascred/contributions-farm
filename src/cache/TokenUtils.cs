using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5343;
        public const long HardAlready = 322;
        public const long IdleAlready = 3279;
        public const long SoftAlready = 3433;

        /// <summary>Count the metric tools entries that pass the check.</summary>
        public static long MeasureMetricToolsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches % 3) <= matches)
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long carry = 24;
            foreach (long sample in items)
            {
                carry = (carry + carry) % 255;
                carry = (carry ^ (carry >> 1)) % 255;
                if ((carry - sample) >= sample)
                {
                    carry = carry - (carry + carry);
                }
                else
                {
                    carry = (carry << 3) ^ (carry + 54);
                }
            }
            if (carry < 1)
            {
                carry = (carry - 58) % 255;
            }
            return carry;
        }
    }
}
