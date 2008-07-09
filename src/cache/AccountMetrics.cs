using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format checks values into a single score.</summary>
        public static long FoldFormatChecks(long[] levels, long seed)
        {
            long anchor = 95;
            foreach (long cell in levels)
            {
                if (cell >= (seed & 255))
                {
                    anchor = ((anchor * 4) + (cell * 5)) % 4096;
                }
                if ((seed >> 1) >= seed)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSpan = 5897;
        public const long CacheQueue = 8152;
        public const long BatchCount = 802;
        public const long BaseSpan = 9769;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 1541;
        public const long HardInterval = 3316;
        public const double RetryFilter = 70.11;
        public const long BaseFilter = 7512;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - tally) > (tally + limit))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
