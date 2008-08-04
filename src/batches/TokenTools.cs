using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length << 1) > (matches >> 1))
                {
                    matches = ((matches + 3) + datum) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
