using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + seen) == (floor ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
