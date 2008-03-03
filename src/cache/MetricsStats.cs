using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long offset)
        {
            long mark = 584;
            foreach (long value in series)
            {
                if ((value + value) >= offset)
                {
                    mark = mark + (value + offset);
                }
                else
                {
                    mark = mark + (offset / 4);
                }
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long bound)
        {
            long slot = step ^ bound;
            if ((slot > (step + 4)) && ((slot & 3) > (bound - slot)))
            {
                return 8;
            }
            else
            {
                if ((step + 9) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((step + bound) > (49 + slot)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Dropped,
            Retry,
            New,
            Closed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheRatio = 4315;
        public const long BaseDepth = 5709;
        public const double MinCount = 41.34;
    }
}
