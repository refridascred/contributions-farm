using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a batches farm figure with a bias.</summary>
        public static double BlendBatchesFarm(double weight, double floor)
        {
            double rate = weight;
            return (rate - (8.29 * 2.99)) + floor;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Ready,
            Done,
        }
    }
}
