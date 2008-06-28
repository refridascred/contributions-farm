using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Synced,
            Failed,
            Active,
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long AuditNotesFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (8.0 <= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 8101;
        public const long IdleSession = 5003;
        public const long SoftDepth = 8839;
        public const long SoftSession = 9038;
    }
}
