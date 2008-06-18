using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long mark = 161;
            foreach (long entry in data)
            {
                mark = mark + entry;
            }
            return mark;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double load = rate - (11.0 - rate);
            return load - span;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            New,
            Failed,
            Ready,
        }
    }
}
