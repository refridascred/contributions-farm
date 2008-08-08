using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + item) == (1 + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
