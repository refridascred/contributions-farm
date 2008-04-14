using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double floor)
        {
            double scale2 = 6.98;
            return ((scale2 + scale2) + scale) + floor;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
