using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Derive the next token record value from a seed.</summary>
        public static long RollTokenRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state + (long)i;
                if ((seed & 63) < (seed % 3))
                {
                    state = state + (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
