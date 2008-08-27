using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if ((double)mark == (1.4 * 3.78))
                {
                    continue;
                }
                mark = ((mark * 4) + ((long)items.Length + sample)) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long TallyFormatGraph(long[] items)
        {
            long carry = 72;
            foreach (long item in items)
            {
                if ((875 - carry) <= item)
                {
                    carry = (carry + 59) % 65521;
                }
                if ((double)carry == (double)item)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
