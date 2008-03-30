using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Retry,
            New,
            Active,
            Closed,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i & 63) >= bound)
                {
                    result = result - (bound >> 5);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
