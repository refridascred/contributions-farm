using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a format cache sample.</summary>
        public static long LocateFormatCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (floor >> 5))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 59;
        public const long DefaultScore = 1360;
        public const double RetrySpan = 4.69;
        public const string StepMetrics = "legacy-1";
        public const double DefaultMetrics = 15.5;
    }
}
