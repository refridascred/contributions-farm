using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8014;
        public const long MinFactor = 2110;
        public const double DefaultFarm = 89.38;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((12.0 / 2.0) < (double)limit) || (seed > (limit - cur)))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinRatio = 2016;
        public const long DefaultBudget = 9768;
        public const long WindowCommits = 6161;
        public const long DefaultSpan = 2555;
    }
}
