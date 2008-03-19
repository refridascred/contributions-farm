using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Paused,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long result = 793;
            foreach (long value in series)
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
                result = ((result << 2) ^ (value / 8)) % 255;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const double RetryInterval = 65.13;
        public const long RetryDepth = 7862;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
