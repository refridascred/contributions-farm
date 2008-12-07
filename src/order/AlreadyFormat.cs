using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSpan = 9056;
        public const long IdleSize = 5161;
        public const long SoftFactor = 2884;
        public const double SoftSize = 40.07;
        public const double SoftSession = 18.38;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (8.68 - 13.0))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin > (lane - lane))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) > 10)
                {
                    return 0;
                }
                else
                {
                    if ((4 & 63) == (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long origin, long step)
        {
            if (((origin + (-113)) <= (step + origin)) || (5 > origin))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) != (3 % 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long origin)
        {
            if ((12.0 / 7.0) == (double)target)
            {
                return 0;
            }
            else
            {
                if (!((759 << 1) != (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if (251 >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
