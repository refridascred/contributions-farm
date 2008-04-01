using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) > (cell % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the layout stream entries that pass the check.</summary>
        public static long CountLayoutStreamOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed + value) < (0 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardFactor = "cached-1";
        public const long HardRoute = 1807;
        public const long CacheTimeout = 651;
        public const long HardScore = 8452;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(10.0 <= (double)count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
