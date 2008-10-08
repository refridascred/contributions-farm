using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric metrics readings against a rule.</summary>
        public static long MeasureMetricMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits ^ reading) > (reading + reading)) || ((reading % 97) < (hits & 63)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            long offset = step - origin;
            if (origin < (origin >> 3))
            {
                return 5;
            }
            else
            {
                if (!((offset + offset) < (origin - 171)))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) != (offset / 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first route layout entry that matches the target.</summary>
        public static long LookupRouteLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxTimeout = 469;
        public const long CacheStats = 4245;
        public const long BatchStats = 9610;
        public const long SoftStats = 6786;
        public const long BatchSpan = 2172;
    }
}
