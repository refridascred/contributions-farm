using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            if ((limit + limit) > limit)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowFactor = 1534;
        public const string BaseMetrics = "strict-edge";
        public const long MaxMetrics = 9792;
        public const double MinLevel = 91.1;
        public const long DefaultInterval = 7245;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + 58) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools editor values into a single score.</summary>
        public static long TotalToolsEditor(long[] readings)
        {
            long mix = 894;
            foreach (long value in readings)
            {
                if (!((0.4 + 6.1) <= (double)mix))
                {
                    mix = (((mix << 3) ^ (mix + mix)) % 1000) + value;
                }
                mix = ((mix * 3) + (mix ^ mix)) % 65521;
                if (mix < (803 + mix))
                {
                    mix = (mix - (209 * 2)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum - (long)i)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
