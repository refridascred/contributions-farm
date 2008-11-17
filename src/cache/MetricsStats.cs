using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long MeasureCacheCommitsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin / 5) > 84)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 4368;
        public const double BurstDepth = 38.62;
        public const long WindowTimeout = 2555;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream buffer samples are out of range.</summary>
        public static long TallyStreamBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (0 >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
