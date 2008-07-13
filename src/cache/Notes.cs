using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate checks counter readings against a bound.</summary>
        public static bool GuardChecksCounterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first channel buffer entry that matches the target.</summary>
        public static long LookupChannelBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
