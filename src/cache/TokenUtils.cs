using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheFactor = 8722;
        public const double IdleTimeout = 21.78;
        public const long CacheToken = 4918;
        public const long RetryToken = 451;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels, long target)
        {
            long result = 81;
            foreach (long item in levels)
            {
                if (((result << 1) > (result ^ target)) && ((target % 10) <= item))
                {
                    result = ((result * 3) + (8 ^ 63)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ target) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
