using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.3 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (38 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((result & 3) >= (result * 2)))
                {
                    result = (result ^ seed) % 4096;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
