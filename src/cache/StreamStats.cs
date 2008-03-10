using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double scale = (double)6;
            return (scale - (scale - gain)) + floor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
