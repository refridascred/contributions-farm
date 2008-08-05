using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
