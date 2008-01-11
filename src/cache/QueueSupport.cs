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

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
