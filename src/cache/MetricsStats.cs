using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count batch entry pairs that satisfy a relation.</summary>
        public static long PairBatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double bias = ratio + offset;
            if (bias > (ratio / 7.0))
            {
                bias = bias + (double)0;
            }
            return bias + 0.69;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches < (matches * 4))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Dropped,
            New,
        }
    }
}
