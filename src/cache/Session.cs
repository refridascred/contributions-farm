using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double mean = weight + floor;
            if (mean < (mean - 0.01))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((offset % 16) >= (item % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Grade a graph filter value against two limits.</summary>
        public static long SortGraphFilter(long seed, long offset)
        {
            if ((seed < offset) && ((seed / 3) == (seed - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset / 8) < (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
