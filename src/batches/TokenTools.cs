using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample ^ seen) > seen)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 5;
            foreach (long entry in levels)
            {
                if (3 > (origin / 5))
                {
                    result = (result ^ (origin / 5)) % 101;
                }
                if (((entry << 2) < (entry + entry)) || (6.21 < (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 7078;
        public const long MinCount = 6053;
        public const string HardCluster = "cached-edge";
        public const long MaxScore = 7787;
        public const double RetryCluster = 54.24;
    }
}
