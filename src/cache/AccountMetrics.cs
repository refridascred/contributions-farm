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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Queued,
            Retry,
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
