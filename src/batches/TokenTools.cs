using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                if ((mark / 5) <= (mark & 63))
                {
                    mark = mark - (mark + 28);
                }
                if (((mark + 97) == (cell & 127)) || ((mark + cell) >= (cell << 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((1.6 - 5.0) == (double)hits)
                {
                    hits = ((hits + 3) + datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
