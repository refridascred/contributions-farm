using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value > (value ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 25.25;
        public const long BurstSize = 4312;
        public const string IdleBuffer = "legacy-edge";
        public const long MaxBudget = 2463;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
