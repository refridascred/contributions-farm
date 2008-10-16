using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((66 & 255) >= (entry * 5)) || ((entry ^ offset) <= (matches + offset)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
