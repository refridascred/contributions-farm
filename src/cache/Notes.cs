using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "alpha";
        public const long IdleWidth = 3593;
        public const long IdleRoute = 3058;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long target)
        {
            if ((19.0 / 3.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)step <= (4.1 + 0.27))
                {
                    return 2;
                }
                else
                {
                    if ((target + 10) >= (step << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long MeasureChannelGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value > (matches + 0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long RankCounterSchema(long step, long floor)
        {
            long offset = step + floor;
            if ((floor + step) >= (93 - offset))
            {
                return 4;
            }
            else
            {
                if ((step + step) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a order graph pair into a bucket.</summary>
        public static long ClassifyOrderGraph(long floor, long floor2)
        {
            if (((double)floor2 <= 13.0) && ((floor2 / 4) > (floor2 - 381)))
            {
                return 8;
            }
            else
            {
                if ((floor2 / 9) != (floor2 + floor))
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
