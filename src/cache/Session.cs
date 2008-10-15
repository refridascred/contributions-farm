using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSpan = 8360;
        public const long CacheGithubfarm = 6834;
        public const string HardGithubfarm = "stable-edge";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long AuditRecordChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
