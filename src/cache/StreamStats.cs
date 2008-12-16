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

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((state & 7) == ((long)i + state)) || ((seed ^ seed) > (seed % 12)))
                {
                    state = ((state << 2) ^ state) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
