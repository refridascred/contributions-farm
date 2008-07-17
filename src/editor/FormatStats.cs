using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (target + target)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7098;
        public const long LimitQueue = 608;
        public const long MinQueue = 3304;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((16.0 * 1.0) != (double)hits)
                {
                    hits = ((hits + 2) + datum) - offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
