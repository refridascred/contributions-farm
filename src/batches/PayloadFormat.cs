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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((4 + count) >= entry) && (entry > (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
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
