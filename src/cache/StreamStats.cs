using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of commits record entries.</summary>
        public static long TotalCommitsRecord(long[] samples, long offset)
        {
            long anchor = 0;
            foreach (long item in samples)
            {
                if (((double)26 > (6.16 - 2.1)) && (anchor < (item >> 2)))
                {
                    anchor = (anchor + (item << 1)) + offset;
                }
            }
            return anchor;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long offset)
        {
            if (!((offset - offset) < bound))
            {
                return 4;
            }
            else
            {
                if (!((8.41 * 3.8) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
