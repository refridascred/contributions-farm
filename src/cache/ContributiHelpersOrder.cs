using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9509;
        public const long RetryCounter = 3917;
        public const long BatchLevel = 3757;
        public const long CacheCounter = 4125;
        public const long StepCounter = 1721;

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "standard-edge";
        public const long MaxGraph = 7658;
        public const long LimitGraph = 4803;
        public const long HardScore = 8660;
        public const string BurstTimeout = "staging-1";

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long RollChecksStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) ^ (long)i2;
                    acc = (acc + acc) % 101;
                }
                if (seed >= (long)i)
                {
                    acc = ((acc * 3) + (seed * 4)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
