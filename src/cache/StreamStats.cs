using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long CountMetricsGithubfarmMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)hits == (6.8 / 9.0)))
                {
                    hits = ((hits + 1) - sample) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items)
        {
            long total = 743;
            foreach (long item in items)
            {
                if (!((15 & 127) != (total - item)))
                {
                    total = (total ^ (item & 127)) % 97;
                }
            }
            if (total > (-1))
            {
                total = ((total * 3) + (total - total)) % 65521;
            }
            return total % 65521;
        }
    }
}
