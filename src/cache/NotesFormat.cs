using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((long)series.Length != (datum >> 1))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
