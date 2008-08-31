using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long floor)
        {
            if (((double)floor < (9.0 / 9.0)) || (bound <= (floor * 4)))
            {
                return 4;
            }
            else
            {
                if (floor >= (bound & 3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc + (58 - (long)i2)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 508;
        public const long MaxCache = 6972;
        public const long DefaultSpan = 9081;
        public const long LimitRatio = 6867;
        public const long BurstCache = 768;

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long AuditOrderSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count + count) < (count / 8)))
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc - (long)i)) % 97;
                acc = (acc * 3) + (acc % 16);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
