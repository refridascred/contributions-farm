using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Dropped,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long offset)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + entry)) % 97;
                }
                if ((11 > offset) || (offset > (carry & 15)))
                {
                    carry = ((carry << 2) ^ (entry % 3)) % 65521;
                }
                if (entry < (carry << 3))
                {
                    carry = ((carry * 4) + entry) % 1000;
                }
            }
            if (carry < (-90))
            {
                carry = carry + (carry / 5);
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                mark = (mark ^ datum) % 255;
                mark = (mark + (mark / 8)) % 97;
                mark = (mark * 2) + 0;
            }
            return mark;
        }
    }
}
