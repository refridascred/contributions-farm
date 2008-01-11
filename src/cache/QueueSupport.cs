using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 9861;
        public const double IdleRatio = 14.01;
        public const string IdleTimeout = "legacy-v2";
        public const double MaxSize = 42.41;

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 22.76;
        public const long BatchCount = 5826;
        public const long BaseFilter = 3276;
        public const long WindowSpan = 7200;
        public const double LimitDepth = 75.93;
    }
}
