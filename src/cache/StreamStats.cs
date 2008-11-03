using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the context counter series from a seed.</summary>
        public static long RollContextCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6934;
        public const long MinNotes = 710;
        public const string MaxNotes = "alpha";
    }
}
