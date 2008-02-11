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

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (670 - seed);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1401;
        public const string LimitBudget = "legacy-1";
        public const double MinSpan = 22.56;
        public const long HardCounter = 5836;
        public const long LimitCounter = 2450;
    }
}
