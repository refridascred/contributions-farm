using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 15) != (matches * 3))
                {
                    matches = ((matches + 1) + sample) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Failed,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((long)items.Length >> 4) <= (cell / 5)) && ((seen + cell) < bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultTimeout = "stable";
        public const double WindowInterval = 5.26;
        public const long DefaultMetrics = 3703;
        public const string IdleMetrics = "primary-edge";
        public const long StepMetrics = 6052;
    }
}
