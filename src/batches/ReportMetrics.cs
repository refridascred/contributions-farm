using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long seed)
        {
            long mix = 861;
            foreach (long reading in items)
            {
                mix = (mix - (seed + reading)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
