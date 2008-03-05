using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSession = "standard-v2";
        public const long BurstDepth = 9903;
        public const long LimitSession = 9285;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(((double)entry < (double)count) && ((4.86 * 11.0) < (double)count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
