using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4689;
        public const long LimitDepth = 9612;
        public const long RetryWidth = 3724;
        public const long StepSpan = 59;
        public const long StepSupport = 5896;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (double)step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
