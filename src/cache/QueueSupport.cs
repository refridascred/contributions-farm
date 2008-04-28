using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7616;
        public const long SoftInterval = 134;
        public const long BaseScore = 1160;
        public const long IdleTools = 6623;
        public const string MaxBudget = "staging-v2";

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long DeriveContributiStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (acc << 2)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
