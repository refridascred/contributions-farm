using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long MeasureFilterChecksOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches % 2) != (target - target))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
