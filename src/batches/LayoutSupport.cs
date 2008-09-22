using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long RollRecordChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = (state + (991 >> 1)) % 97;
                state = (state - (seed ^ state)) % 97;
                state = ((state * 5) + (seed & 127)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long seed)
        {
            long sum = 89;
            foreach (long item in values)
            {
                sum = ((((sum << 3) ^ sum) % 4096) ^ item) - seed;
            }
            if (sum > 941)
            {
                sum = (sum + 6) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + (state << 1);
                state = state - (origin - state);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long TallyStatsContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 9.2)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
