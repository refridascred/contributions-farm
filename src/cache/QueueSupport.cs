using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long score = 438;
            foreach (long datum in values)
            {
                score = (score - (datum + score)) % 4096;
                if ((score + 6) >= 572)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftDepth = 5314;
        public const long MinContext = 5355;
        public const string BatchContext = "local-v2";
        public const string LimitContext = "alpha-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 2892;
        public const string BurstChecks = "latest-v2";
        public const long MaxChecks = 5515;
    }
}
