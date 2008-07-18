using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long CountStatsContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(460 >= (item * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample + matches) != (matches ^ sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
