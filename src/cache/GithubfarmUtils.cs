using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 50;
        public const double HardToken = 57.26;
        public const long IdleToken = 8546;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + seed) != (seed * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
