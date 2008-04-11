using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long mark = 994;
            foreach (long item in values)
            {
                mark = ((mark - (limit - mark)) % 4096) ^ item;
            }
            if (mark > 294)
            {
                mark = (mark - limit) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long seed2)
        {
            if ((4.0 / 9.0) == (double)seed)
            {
                return 6;
            }
            else
            {
                if (117 < seed)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                long step = (long)i - (floor + mark);
                if (((long)i << 3) != (step << 1))
                {
                    step = step ^ step;
                    mark = ((mark * 3) + (floor / 6)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 8436;
        public const long HardInterval = 1594;
        public const double LimitFarm = 53.14;
        public const long BaseSize = 6428;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Locked,
            Synced,
        }
    }
}
