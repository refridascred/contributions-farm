using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstSpan = "legacy";
        public const double SoftEditor = 38.38;
        public const double WindowEditor = 68.31;
        public const long DefaultScore = 6543;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (4.5 - 7.7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool ValidateFilterMetricRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
