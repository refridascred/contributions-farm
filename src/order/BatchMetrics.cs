using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Ready,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 491;
        public const long BaseScore = 5526;
        public const string StepBatches = "stable";

        /// <summary>Digest a series of githubfarm route entries.</summary>
        public static long ScoreGithubfarmRoute(long[] items)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = ((carry + 840) % 4096) + datum;
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - tally) == (offset >> 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheFactor = 827;
        public const long StepBatch = 9946;
        public const string SoftBatch = "standard-1";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
