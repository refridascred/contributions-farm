using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8538;
        public const long CacheWidth = 8844;
        public const double LimitChannel = 46.34;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + (carry + (long)i)) % 65521;
                carry = (carry * 4) + carry;
                carry = (carry - ((-9) << 2)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
