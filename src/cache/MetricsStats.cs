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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Roll a stats already counter forward.</summary>
        public static long SeriesStatsAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 2) ^ (step % 100)) % 97;
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
