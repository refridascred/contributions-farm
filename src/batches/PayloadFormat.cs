using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally ^ tally) > value) || ((tally >> 4) < (value << 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
