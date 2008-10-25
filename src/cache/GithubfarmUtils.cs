using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a route support counter forward.</summary>
        public static long StepRouteSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + ((long)i - (long)i)) % 1000;
                acc = (acc << 3) ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count commits queue pairs that satisfy a relation.</summary>
        public static long OverlapCommitsQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 4119;
        public const double DefaultInterval = 63.95;
        public const long HardFarm = 1611;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Draft,
            Stale,
            Dropped,
            Closed,
        }
    }
}
