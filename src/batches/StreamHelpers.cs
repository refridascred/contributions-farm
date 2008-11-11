using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1297;
        public const double WindowLevel = 21.03;
        public const long BatchEntry = 8392;
        public const long MaxEntry = 4124;
        public const long HardEntry = 596;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches < offset) || ((offset * 4) > (item - offset))) || (0 <= (item - 8)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            New,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 5761;
        public const long LimitCount = 1265;
        public const double BaseStats = 94.68;
        public const long CacheStats = 2113;
        public const long BatchStats = 3892;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Locked,
            Pending,
            Queued,
        }
    }
}
