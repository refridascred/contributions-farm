using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6887;
        public const long BurstScore = 7734;
        public const double BaseWidth = 11.38;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
