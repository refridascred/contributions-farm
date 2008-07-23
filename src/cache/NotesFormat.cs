using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of filter support readings.</summary>
        public static long TallyFilterSupport(long[] samples, long floor)
        {
            long anchor = -28;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 4) + ((-488) + anchor)) % 97) - floor;
                if (anchor < entry)
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
            }
            return anchor % 1000;
        }
    }
}
