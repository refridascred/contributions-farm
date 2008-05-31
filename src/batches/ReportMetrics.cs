using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long CountToolsBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!!((double)seen > (7.49 - 5.49)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long ScoreEditorMetric(long[] series, long origin)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = total - (total & 31);
                if (((total + origin) != ((long)series.Length ^ total)) && (((long)series.Length / 8) < value))
                {
                    total = (total - (origin % 24)) % 255;
                }
            }
            return total;
        }
    }
}
