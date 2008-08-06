using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Draft,
            New,
            Idle,
            Queued,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheDepth = 3854;
        public const long BurstScore = 9868;
        public const double BurstDepth = 77.06;
        public const long HardCache = 7214;
    }
}
