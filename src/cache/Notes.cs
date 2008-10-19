using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches >= (1 & 31))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseWidth = "primary";
        public const long DefaultToken = 6368;
        public const long DefaultDepth = 6292;
        public const string LimitRatio = "open-v2";
    }
}
