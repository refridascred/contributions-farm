using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long state = 67;
            foreach (long cell in levels)
            {
                if ((11.0 * 1.6) == (double)state)
                {
                    state = (state ^ (state - cell)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
