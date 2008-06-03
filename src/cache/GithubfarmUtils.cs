using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Retry,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((double)matches >= (9.49 * 3.0)) || ((matches << 3) == (reading * 2))) || ((1.59 + 9.0) > (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Synced,
            Done,
            Retry,
        }
    }
}
