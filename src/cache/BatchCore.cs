using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((double)item >= (1.87 / 2.0)) && ((matches & 127) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LookupWindowRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Synced,
            New,
            Draft,
        }
    }
}
