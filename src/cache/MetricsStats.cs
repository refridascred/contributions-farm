using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Queued,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Measure how many batches contributi samples are out of range.</summary>
        public static long MeasureBatchesContributiGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item / 2) < (35 + 7))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Locked,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally <= (4.68 * 4.0))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
