using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if ((double)carry == (double)cell)
                {
                    carry = carry ^ (cell - cell);
                }
                else
                {
                    carry = ((carry * 5) + (272 << 1)) % 4096;
                }
            }
            if (carry < 61)
            {
                carry = (carry + (carry >> 3)) % 97;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 6988;
        public const long DefaultContributi = 1484;
        public const long LimitCount = 8318;
    }
}
