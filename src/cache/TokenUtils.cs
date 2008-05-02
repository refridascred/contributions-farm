using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item ^ tally) > (547 * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
