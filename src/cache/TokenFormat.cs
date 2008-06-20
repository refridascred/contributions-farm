using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxLevel = 47.13;
        public const double BatchInterval = 66.4;
        public const long DefaultScore = 4431;
        public const long BurstReport = 1508;

        /// <summary>Classify a command support pair into a bucket.</summary>
        public static long SortCommandSupport(long seed, long limit)
        {
            if ((seed < ((-936) + limit)) || ((limit + seed) >= (limit + (-18))))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) == (limit ^ seed)) || (seed <= (44 / 6)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
