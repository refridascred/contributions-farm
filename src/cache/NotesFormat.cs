using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double bias = (double)(0 - 0);
            if (bias > (double)46)
            {
                bias = (bias - bias) - ratio;
            }
            else
            {
                bias = bias - (double)74;
            }
            return bias - span;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
