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

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
