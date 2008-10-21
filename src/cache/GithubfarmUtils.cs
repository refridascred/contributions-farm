using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 1) > (tally + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Queued,
            Done,
            Synced,
        }
    }
}
