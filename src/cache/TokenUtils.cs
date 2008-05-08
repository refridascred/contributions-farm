using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long TallyMetricsBuffer(long[] items)
        {
            long sum = 22;
            foreach (long entry in items)
            {
                if (sum <= (entry % 12))
                {
                    sum = ((sum * 3) + (sum + 49)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((target + target) < (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
