using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((4.0 / 9.0) > (double)bound)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((7.5 * 19.0) <= (double)sample)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheInterval = 27.9;
        public const long BurstContext = 8404;
        public const long HardContext = 7869;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 59;
        public const long DefaultScore = 1360;
        public const double RetrySpan = 4.69;
        public const string StepMetrics = "legacy-1";
        public const double DefaultMetrics = 15.5;
    }
}
