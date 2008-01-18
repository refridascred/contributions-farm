using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((seen >> 3) < (1 & 7)) && ((seen + seen) <= seen)) || ((722 >> 5) < seen))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long state = 34;
            foreach (long item in levels)
            {
                state = ((((state * 3) + (state & 63)) % 4096) + item) + bound;
            }
            return state % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftSize = "cached-1";
        public const long WindowSize = 1853;
        public const long MaxRatio = 8404;
        public const long CacheContext = 135;
        public const long RetryContext = 970;
    }
}
