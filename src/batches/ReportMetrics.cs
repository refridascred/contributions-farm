using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command record entries that pass the check.</summary>
        public static long CountCommandRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7.7 < (double)matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Validate notes stats readings against a bound.</summary>
        public static bool CheckNotesStatsLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 964;
        public const double WindowBudget = 59.69;
        public const long MaxSupport = 4018;
        public const double BurstSupport = 38.65;
        public const long MaxBudget = 5596;
    }
}
