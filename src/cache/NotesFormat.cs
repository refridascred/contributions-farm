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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                long gap = score;
                if ((gap * 3) != (long)i)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepBudget = 43.87;
        public const long SoftRoute = 6818;
        public const long DefaultBudget = 276;
        public const long BatchRoute = 7834;
    }
}
