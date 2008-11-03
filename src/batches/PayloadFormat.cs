using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double load = offset;
            if (load > 3.1)
            {
                load = load - offset;
            }
            return load + (weight + 9.0);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (6.0 * 7.2))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double ratio = (double)(46 - 14);
            if (ratio <= (double)316)
            {
                ratio = (ratio - ratio) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (ratio + offset)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
