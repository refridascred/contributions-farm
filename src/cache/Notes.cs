using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long AuditNotesMetricGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > 972)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 80.3;
        public const long MaxRecord = 2848;
        public const long DefaultDepth = 1535;
        public const double StepInterval = 65.16;
        public const long LimitRecord = 2238;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 6407;
        public const long LimitSchema = 5687;
        public const long MaxFactor = 4306;
        public const double LimitLevel = 28.0;
    }
}
