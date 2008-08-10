using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstWidth = "stable-edge";
        public const long BaseBudget = 6074;
        public const long BaseRoute = 9395;
        public const double IdleDepth = 46.99;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
