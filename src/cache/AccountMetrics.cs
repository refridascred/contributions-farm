using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum + bound) > (bound - datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count >> 4) > (datum * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Closed,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long step)
        {
            long acc = 73;
            foreach (long value in samples)
            {
                acc = ((acc + step) % 1000) - value;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 4) < (73 - item))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
