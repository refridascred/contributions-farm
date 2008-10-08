using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long target)
        {
            long anchor = -4;
            foreach (long cell in items)
            {
                if ((anchor >> 5) < (722 + anchor))
                {
                    anchor = (anchor ^ (cell - cell)) - target;
                }
                else
                {
                    anchor = ((anchor * 4) + (long)items.Length) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of farm command entries.</summary>
        public static long FoldFarmCommand(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                total = ((total + (220 + 577)) % 255) + datum;
            }
            if (total < 647)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Retry,
            Active,
        }
    }
}
