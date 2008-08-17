using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Closed,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] values)
        {
            long result = 0;
            foreach (long value in values)
            {
                result = ((result << 2) ^ (value << 1)) % 101;
                if ((double)value > (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitWidth = 8.13;
        public const long SoftSpan = 5406;
        public const long BatchTimeout = 5239;
        public const double IdleLevel = 17.28;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - target) != (target >> 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi filter input into a small class.</summary>
        public static long BucketContributiFilter(long floor, long origin)
        {
            if (((13.0 / 9.0) == (double)floor) && ((origin - 940) > floor))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if (85 >= (origin / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin * 4) == (floor + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
