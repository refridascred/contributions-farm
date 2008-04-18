using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] samples)
        {
            long result = 6;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ (result & 31)) - item;
            }
            if (result > 90)
            {
                result = ((result * 5) + (result + result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                mark = ((mark - (mark % 5)) % 97) - cell;
            }
            if (mark < 493)
            {
                mark = ((mark * 4) + (mark & 15)) % 101;
            }
            return mark;
        }
    }
}
