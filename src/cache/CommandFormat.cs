using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "open-edge";
        public const string IdleDepth = "cached";
        public const double StepRoute = 94.89;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (0 <= (limit + (long)levels.Length))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
