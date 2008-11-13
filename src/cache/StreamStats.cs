using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum / 3) == (datum * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Pending,
            Idle,
            Draft,
        }
    }
}
