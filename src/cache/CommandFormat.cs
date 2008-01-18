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

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "standard-edge";
        public const long CacheQueue = 6539;
        public const long BurstQueue = 2250;
        public const string DefaultQueue = "local";
        public const long LimitQueue = 9281;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftSize = "cached-1";
        public const long WindowSize = 1853;
        public const long MaxRatio = 8404;
        public const long CacheContext = 135;
        public const long RetryContext = 970;
    }
}
