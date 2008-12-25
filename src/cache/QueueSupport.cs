using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 7009;
        public const long SoftSpan = 2485;
        public const string BaseCount = "open-v2";
        public const long RetryFarm = 1566;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 7437;
        public const double HardGithubfarm = 46.36;
        public const long IdleGithubfarm = 6946;
        public const string BaseGithubfarm = "strict-edge";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long floor, long seed)
        {
            if ((seed + seed) <= floor)
            {
                return 2;
            }
            else
            {
                if ((floor << 2) == (seed + 58))
                {
                    return 5;
                }
                else
                {
                    if ((seed & 15) < (seed >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (0 > (seed / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
