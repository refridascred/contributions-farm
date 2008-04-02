using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4968;
        public const double BaseWidth = 72.83;
        public const double IdlePayload = 14.35;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values)
        {
            long anchor = 0;
            foreach (long cell in values)
            {
                anchor = anchor - (cell + anchor);
            }
            if (anchor < 81)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
