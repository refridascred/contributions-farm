using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool ValidateContextCacheBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
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
