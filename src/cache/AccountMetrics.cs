using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command record readings against a rule.</summary>
        public static long CountCommandRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)15)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultInterval = 50.38;
        public const double StepRatio = 18.01;
        public const long BaseInterval = 5474;
        public const double BurstChecks = 81.39;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = (mix ^ (40 >> 2)) ^ value;
            }
            if (mix > 2)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Retry,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen / 3))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
