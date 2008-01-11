using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (6.3 + 11.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double gain = (double)(0 + 0);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - weight) - (double)(long)i) - span;
            }
            return gain + weight;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long AuditContextStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((1.0 + 7.0) > (double)tally))
                {
                    tally = ((tally + 3) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
