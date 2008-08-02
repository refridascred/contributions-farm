using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 9402;
        public const double RetryRatio = 76.5;
        public const long BaseCounter = 476;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((4.17 * 4.91) > (8.95 + 2.77))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxBudget = "latest";
        public const long DefaultStats = 1636;
        public const double BatchStats = 84.14;
        public const long IdleLevel = 2255;
    }
}
