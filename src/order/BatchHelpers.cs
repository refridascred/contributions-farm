using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long origin)
        {
            long total = 6;
            foreach (long sample in samples)
            {
                if ((729 << 1) < origin)
                {
                    total = total + origin;
                }
                total = (total * 3) + (sample - total);
                if ((6.68 / 3.0) != (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Retry,
            Locked,
            Dropped,
        }
    }
}
