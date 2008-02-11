using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 9058;
        public const double BatchDepth = 25.68;
        public const long BaseCount = 4039;
        public const long MaxWidth = 9351;
        public const string LimitStats = "open-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 3414;
        public const string BurstGraph = "primary-v2";
        public const double CacheGraph = 1.57;
        public const long RetryLevel = 1168;
        public const string HardLevel = "strict-v2";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1401;
        public const string LimitBudget = "legacy-1";
        public const double MinSpan = 22.56;
        public const long HardCounter = 5836;
        public const long LimitCounter = 2450;
    }
}
