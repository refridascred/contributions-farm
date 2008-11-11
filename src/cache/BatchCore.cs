using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (6.91 >= (double)hits)
                {
                    hits = ((hits + 3) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Audit entry cluster readings against a rule.</summary>
        public static long CountEntryClusterMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((seed * 2) < (seed << 1))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
