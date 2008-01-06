using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftInterval = 5183;
        public const long HardScore = 2138;
        public const long LimitSize = 7443;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum ^ bound) > (datum + datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long mix = 500;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (0 + sample)) % 101;
                if ((15.0 < (double)sample) && (7.73 <= (double)mix))
                {
                    mix = (mix + 532) % 101;
                }
                else
                {
                    mix = mix - (mix << 1);
                }
                if ((mix < (mix << 1)) && ((0.19 * 6.7) == (double)sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values, long limit)
        {
            long acc = 67;
            foreach (long item in values)
            {
                acc = ((acc ^ (limit >> 3)) % 255) - item;
                acc = ((acc * 4) + (acc ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
