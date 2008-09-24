using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 6;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((15.0 + 2.52) == (double)seed))
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 61;
        public const double BurstTools = 84.38;
        public const long HardTools = 2370;
        public const long LimitTools = 6924;

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long mark = -18;
            foreach (long cell in items)
            {
                if (((double)mark != (5.2 / 4.0)) && ((9.0 + 4.9) >= (double)mark))
                {
                    mark = (((mark * 5) + mark) % 4096) - cell;
                }
                else
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((0.4 + 0.1) >= (double)seed) || ((double)seen != (double)reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
