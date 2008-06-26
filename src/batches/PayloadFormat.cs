using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum ^ sum) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long carry = 11;
            foreach (long sample in items)
            {
                carry = ((carry * 5) + (608 >> 4)) ^ sample;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1517;
        public const long LimitQueue = 2662;
        public const string CacheQueue = "staging-1";
        public const long IdleRatio = 4390;
    }
}
