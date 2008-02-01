using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1233;
        public const long LimitTimeout = 8931;
        public const string WindowCluster = "alpha";

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long MeasureStatsContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
