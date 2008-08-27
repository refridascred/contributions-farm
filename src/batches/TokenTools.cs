using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels)
        {
            long sum = 48;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + 9) % 101) ^ entry;
            }
            return sum;
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
