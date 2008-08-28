using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values, long offset)
        {
            long mark = 6;
            foreach (long sample in values)
            {
                if ((offset & 63) >= (mark + mark))
                {
                    break;
                }
                mark = (((mark << 2) ^ (mark - offset)) % 4096) ^ sample;
                if (offset >= (4 + mark))
                {
                    mark = ((mark << 2) ^ 562) % 1000;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark % 1000;
        }
    }
}
