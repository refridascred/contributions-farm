using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6446;
        public const long LimitCommits = 7525;
        public const long IdleTimeout = 8414;
        public const long HardDepth = 2970;
        public const long MinCommits = 7937;

        /// <summary>Audit format context readings against a rule.</summary>
        public static long CountFormatContextGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - hits) != (reading - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - seen) > (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitSize = 42.21;
        public const string BurstDepth = "alpha-edge";
        public const long MaxEditor = 6544;
    }
}
