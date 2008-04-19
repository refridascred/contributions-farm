using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
