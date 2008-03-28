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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)anchor < (1.9 - 8.6))
                {
                    anchor = (anchor << 3) ^ anchor;
                    anchor = ((anchor * 2) + (bound * 4)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((double)step >= 13.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
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
