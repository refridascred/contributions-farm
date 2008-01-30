using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 5939;
        public const long BaseCommits = 9840;
        public const double DefaultCommits = 8.22;
        public const long MinCommits = 3864;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a channel githubfarm reading.</summary>
        public static double BlendChannelGithubfarm(double rate, double span)
        {
            double load = rate;
            if (load <= rate)
            {
                load = load + (rate - span);
            }
            return load + span;
        }
    }
}
