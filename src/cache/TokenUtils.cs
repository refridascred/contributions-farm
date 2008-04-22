using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Done,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Accumulate cache support samples.</summary>
        public static long DigestCacheSupport(long[] items, long origin)
        {
            long total = 140;
            foreach (long datum in items)
            {
                total = ((((total * 2) + (long)items.Length) % 101) - datum) + origin;
            }
            return total;
        }

        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long MeasureEntryMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((double)datum <= 15.0) || ((datum >> 4) == (datum % 7)))
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
