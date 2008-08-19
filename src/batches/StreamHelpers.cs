using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally >= (item + offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long seed, long bound)
        {
            long edge = seed + bound;
            if (((18.0 * 4.1) <= (3.7 - 16.0)) && (seed >= (edge - seed)))
            {
                return 8;
            }
            else
            {
                if (!((856 - bound) >= bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 9) >= (-328))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge << 2) <= (edge ^ bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer layout readings.</summary>
        public static long ScoreBufferLayout(long[] samples, long seed)
        {
            long state = 372;
            foreach (long item in samples)
            {
                state = (state - (seed & 255)) % 4096;
                state = (state ^ (item + state)) % 4096;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardSize = 1965;
        public const long SoftWindow = 634;
        public const long LimitWindow = 2129;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepWidth = 91.33;
        public const string DefaultSpan = "fallback-v2";
        public const string IdleMetrics = "fallback-v2";
        public const long MaxSize = 6403;
        public const double BurstMetrics = 35.36;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
