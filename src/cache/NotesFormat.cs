using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - (-7)) != (773 << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
