using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a route counter figure with a bias.</summary>
        public static double BlendRouteCounter(double weight, double span)
        {
            double mean = weight;
            return mean + (weight + span);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
