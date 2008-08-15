using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 75.91;
        public const double MaxTimeout = 5.59;
        public const long HardCluster = 8600;
        public const long SoftBudget = 5960;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Dropped,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((108 + item) <= (tally * 3)) && ((item - 723) <= (item + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
