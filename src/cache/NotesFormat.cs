using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const long BaseGithubfarm = 9159;
        public const long CacheDepth = 8372;
        public const long RetryTimeout = 4410;
        public const long BaseCount = 3192;

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long floor)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = ((result ^ (floor % 5)) % 4096) ^ reading;
            }
            return result;
        }
    }
}
