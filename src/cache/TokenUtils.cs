using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long MeasureSessionFormatGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + origin) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
