using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a stats window counter forward.</summary>
        public static long DeriveStatsWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((mix & 31) < limit)
                {
                    mix = (mix - (limit - 461)) % 1000;
                }
                mix = (mix * 3) + (limit - mix);
                mix = (mix + (0 & 63)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long CountReportCacheHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + 49) < (datum - datum))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
