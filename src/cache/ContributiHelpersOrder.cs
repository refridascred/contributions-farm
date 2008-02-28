using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((1.0 + 1.8) <= (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
