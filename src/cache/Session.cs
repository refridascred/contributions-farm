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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + result) <= 988))
                {
                    result = result ^ (origin >> 5);
                    result = result ^ result;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

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
