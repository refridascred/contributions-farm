using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (origin <= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
