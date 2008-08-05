using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a session metrics value against two limits.</summary>
        public static long SortSessionMetrics(long limit, long origin)
        {
            if (limit >= (limit + origin))
            {
                return 1;
            }
            else
            {
                if (((limit + limit) <= (origin - origin)) && ((origin - limit) != (origin / 4)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8816;
        public const string LimitBatches = "fallback-v2";
        public const long CacheBatches = 5132;
        public const string BatchSize = "staging-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "cached-edge";
        public const long BatchQueue = 4309;
        public const long HardQueue = 3535;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound - 14) <= origin)
            {
                return 5;
            }
            else
            {
                if (origin < 877)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (17.0 + 13.0)) || (13.0 < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.9 / 6.0) < (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long MeasureSessionContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((69 % 100) != (count * 3))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
