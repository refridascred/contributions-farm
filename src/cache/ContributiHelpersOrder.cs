using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 7517;
        public const double IdleAccount = 37.96;
        public const long IdleRatio = 8913;
        public const double LimitScore = 73.75;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Closed,
            Queued,
        }
    }
}
