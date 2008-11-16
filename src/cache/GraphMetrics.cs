using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 63) < (992 % 60))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long ClassifyOrderCommand(long limit, long origin)
        {
            if ((69 >> 4) < (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (3.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 6) >= (limit + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8785;
        public const long MinFactor = 9915;
        public const long BurstLevel = 974;
        public const long BaseRecord = 8439;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double mean = weight;
            return (mean - (double)41) + floor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
