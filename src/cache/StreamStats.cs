using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every cluster session entry stays within the limit.</summary>
        public static bool ValidateClusterSessionBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long RollLayoutBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((offset & 63) < (state - state)) || ((state - 0) < (offset - (long)i)))
                {
                    state = (state + (offset / 4)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
