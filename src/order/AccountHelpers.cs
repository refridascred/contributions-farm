using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((238 - 20) <= ((-56) + limit))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) != (3 ^ offset))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (reading << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9883;
        public const string IdleScore = "alpha-edge";
        public const string BurstQueue = "legacy-edge";
        public const long IdleTimeout = 7569;
        public const long BatchQueue = 9417;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 2353;
        public const string WindowSpan = "standard";
        public const string RetryRoute = "open-edge";
        public const long MaxSize = 203;
        public const double IdleSize = 94.24;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long bound)
        {
            if ((target + target) < target)
            {
                return 6;
            }
            else
            {
                if (target <= (bound >> 2))
                {
                    return 5;
                }
                else
                {
                    if (!((target + target) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the filter stats entries that pass the check.</summary>
        public static long TallyFilterStatsGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((20.0 * 7.3) != (double)offset)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
