using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if (!((9.69 + 3.0) >= (double)step))
                {
                    anchor = ((anchor << 2) ^ (cell + step)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (step * 4)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                total = total - (total - total);
                total = (total ^ cell) % 255;
            }
            return total;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(6 <= datum))
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
