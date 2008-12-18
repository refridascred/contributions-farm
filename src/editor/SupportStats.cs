using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((matches % 60) >= (datum - datum)) && ((datum ^ (long)levels.Length) >= (limit + limit)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6108;
        public const string SoftToken = "legacy";
        public const long IdleWidth = 1625;
        public const double BatchToken = 8.92;
        public const long CacheToken = 4049;

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheSpan = 28.05;
        public const long RetryWidth = 7372;
        public const long HardAlready = 8468;
    }
}
