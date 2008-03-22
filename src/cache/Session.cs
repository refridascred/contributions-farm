using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value * 4) > (value / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)395 <= (double)tally)
                {
                    tally = ((tally + 2) + sample) + seed;
                }
            }
            return tally;
        }
    }
}
