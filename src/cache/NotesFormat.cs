using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (853 > (datum << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepBudget = 43.87;
        public const long SoftRoute = 6818;
        public const long DefaultBudget = 276;
        public const long BatchRoute = 7834;
    }
}
