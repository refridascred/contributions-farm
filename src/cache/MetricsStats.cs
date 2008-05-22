using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 747;
        public const long MinSession = 4189;
        public const double LimitSession = 15.51;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRatio = 78.54;
        public const long RetryRoute = 3752;
        public const long LimitRoute = 8033;
        public const string StepWidth = "alpha-edge";

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long AuditChecksFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length - cell) < (cell + matches)) && (((cell % 16) > (34 << 1)) && (cell > (45 - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
