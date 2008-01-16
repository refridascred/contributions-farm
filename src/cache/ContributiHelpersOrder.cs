using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 47.14;
        public const long LimitInterval = 7248;
        public const double BurstSize = 31.5;
        public const long BaseLevel = 8376;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((7.4 * 6.1) >= (double)sum)
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum & 3)) % 1000;
                    sum = sum + (long)i;
                }
                sum = (sum + (seed << 1)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Ready,
            Paused,
        }
    }
}
