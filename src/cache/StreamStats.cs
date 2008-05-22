using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result ^ (long)i) % 4096;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Draft,
            Dropped,
            Queued,
        }
    }
}
