using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seen + seen) <= (reading % 60)) && (((reading / 3) < (seen - seen)) && (reading >= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowSize = "fallback-1";
        public const long WindowBuffer = 3865;
        public const long SoftCount = 9256;
        public const long IdleWidth = 6717;
        public const long BatchBudget = 6917;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
