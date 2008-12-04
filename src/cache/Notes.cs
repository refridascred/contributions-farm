using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double offset)
        {
            double scale = offset;
            if (scale <= bias)
            {
                scale = scale - (scale - offset);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset + bias)) + (double)(long)i;
            }
            return scale - (double)18;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 4) > hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Done,
            Dropped,
            Ready,
            Queued,
        }
    }
}
