using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long AuditGithubfarmClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell > (665 * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) != (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
