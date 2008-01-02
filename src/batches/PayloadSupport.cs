using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + 10) <= (item & 31))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
