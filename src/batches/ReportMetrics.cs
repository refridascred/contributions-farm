using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 4) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 3145;
        public const string MaxRatio = "open-v2";
        public const double StepNotes = 65.4;
        public const double HardScore = 1.39;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits - hits) >= hits) || !((double)hits >= 8.53))
                {
                    hits = ((hits + 1) + datum) - offset;
                }
            }
            return hits;
        }
    }
}
