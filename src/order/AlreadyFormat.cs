using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Pending,
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double mean = (floor - rate) / 6.0;
            return mean - (mean / 9.0);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor session entry stays within the limit.</summary>
        public static bool GuardEditorSessionBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (origin < (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
