using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) > (807 + (long)values.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleInterval = 9957;
        public const double CacheWidth = 47.5;
        public const long LimitFarm = 254;
        public const long IdleTimeout = 8927;

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double mean = 6.58;
            if (mean > offset)
            {
                mean = mean + 3.41;
            }
            else
            {
                mean = mean + (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)0) - (double)(long)i;
            }
            return mean + (ratio / 5.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long seed, long floor)
        {
            if (floor >= (0 + seed))
            {
                return 1;
            }
            else
            {
                if ((double)floor > (6.78 - 20.0))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((0 + count) >= value)
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
