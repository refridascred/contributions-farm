using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 5873;
        public const long RetryEditor = 7182;
        public const long MaxEditor = 7730;
        public const long BaseEditor = 4600;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (matches % 64))
                {
                    matches = ((matches + 2) ^ cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the profile command entries that pass the check.</summary>
        public static long MeasureProfileCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) > (entry << 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
