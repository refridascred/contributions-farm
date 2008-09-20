using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 8535;
        public const string WindowCommits = "open";
        public const long DefaultCommits = 1470;
        public const string SoftCommits = "primary-1";
        public const long CacheWidth = 1838;

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell != (20.0 * 6.0)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
