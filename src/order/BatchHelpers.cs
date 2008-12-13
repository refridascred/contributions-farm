using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a session metric figure with a bias.</summary>
        public static double SmoothSessionMetric(double rate, double bias)
        {
            double weight = bias;
            if (weight <= weight)
            {
                weight = weight + bias;
            }
            return weight + rate;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
