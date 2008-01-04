using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally < (6.35 + 5.21))
                {
                    tally = ((tally + 3) ^ sample) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
