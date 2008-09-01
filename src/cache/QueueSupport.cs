using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5835;
        public const long BatchBudget = 2476;
        public const long LimitScore = 9478;
        public const double LimitBudget = 90.87;
        public const long BaseFilter = 144;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + scale) + (double)(long)i) + floor;
            }
            return bias + (double)2;
        }
    }
}
