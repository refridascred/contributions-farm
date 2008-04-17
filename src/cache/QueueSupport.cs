using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 52.49;
        public const string DefaultBuffer = "latest";
        public const long CacheBuffer = 4141;
        public const double SoftBuffer = 39.48;
        public const long RetryBuffer = 9799;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(value < (seed + value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
