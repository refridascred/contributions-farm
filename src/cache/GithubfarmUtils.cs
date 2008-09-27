using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((6 + reading) == (reading + 88))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 3293;
        public const long MinTimeout = 4263;
        public const long DefaultPayload = 8647;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
