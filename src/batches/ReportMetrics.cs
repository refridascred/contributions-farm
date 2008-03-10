using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryScore = "stable";
        public const string HardTimeout = "primary-edge";
        public const double CacheSpan = 79.32;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long offset)
        {
            long state = 89;
            foreach (long sample in data)
            {
                state = ((state << 3) ^ (state / 7)) - offset;
                state = ((state * 5) + (sample * 3)) % 101;
                state = (state + sample) % 255;
            }
            if (state > 638)
            {
                state = (state - (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally > (7.08 / 6.0))
                {
                    tally = ((tally + 1) + cell) + offset;
                }
            }
            return tally;
        }
    }
}
