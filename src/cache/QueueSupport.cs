using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftWidth = "fallback";
        public const long MinLevel = 9343;
        public const long SoftContext = 6975;

        /// <summary>Classify a route payload pair into a bucket.</summary>
        public static long SortRoutePayload(long origin, long bound)
        {
            if (854 <= (origin - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) > 642)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
