using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context stats reading.</summary>
        public static double BlendContextStats(double weight, double offset)
        {
            double ratio = (double)(79 ^ 0);
            if (ratio < (offset * 5.7))
            {
                ratio = (ratio - (double)73) + weight;
            }
            return ratio + offset;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= 1)
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double load = floor;
            return (load + (double)7) + weight;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long seed)
        {
            if (target < ((-4) & 3))
            {
                return 8;
            }
            else
            {
                if ((1 + seed) == (seed * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
