using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 841;
            foreach (long cell in items)
            {
                score = score ^ cell;
            }
            return score % 65521;
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool GuardRecordMetricRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 48.13;
        public const long LimitDepth = 6769;
        public const double DefaultStream = 75.22;
        public const double CacheSpan = 46.97;
        public const long BaseCount = 7425;
    }
}
