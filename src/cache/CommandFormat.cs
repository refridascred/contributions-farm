using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (double)75)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxTimeout = "alpha-1";
        public const string BatchToken = "latest-edge";
        public const long LimitRatio = 8126;
        public const string CacheSpan = "strict";
    }
}
