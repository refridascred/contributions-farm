using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((3 % 2) >= seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a checks notes counter forward.</summary>
        public static long SeriesChecksNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Draft,
            Pending,
        }
    }
}
