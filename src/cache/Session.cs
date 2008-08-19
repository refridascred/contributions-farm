using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell < (matches / 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long total = 8;
            foreach (long item in values)
            {
                total = (total ^ (item * 5)) % 97;
                if ((item & 127) == (item / 4))
                {
                    total = (total + item) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            long step2 = target ^ step;
            if ((step2 << 1) > (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < step) || ((double)target == (18.0 * 0.9)))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 - 3.4) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 3907;
        public const long CacheMetrics = 776;
        public const long RetryFactor = 6331;
        public const long SoftFactor = 6039;
    }
}
