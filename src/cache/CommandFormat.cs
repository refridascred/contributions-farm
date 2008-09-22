using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stats route samples are out of range.</summary>
        public static long TallyStatsRouteMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) == (seed - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3010;
        public const double CacheRatio = 56.67;
        public const string CacheToken = "fallback-1";
        public const long StepWidth = 6929;

        /// <summary>Accumulate layout command samples.</summary>
        public static long DigestLayoutCommand(long[] readings)
        {
            long anchor = 711;
            foreach (long cell in readings)
            {
                anchor = (anchor + (cell + cell)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "legacy";
        public const long IdleGraph = 8594;
        public const long LimitInterval = 4199;
    }
}
