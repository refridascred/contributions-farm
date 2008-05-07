using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the githubfarm schema entries that pass the check.</summary>
        public static long TallyGithubfarmSchemaMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound ^ tally) < (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
