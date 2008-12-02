using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9746;
        public const string WindowLevel = "alpha";
        public const long BurstTimeout = 7071;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long TallyGithubfarmEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (seen - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
