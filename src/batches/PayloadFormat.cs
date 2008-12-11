using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftFactor = 6410;
        public const long LimitInterval = 244;
        public const double BaseScore = 83.13;
        public const long DefaultChecks = 2552;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) >= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen >= (0 % 8))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
