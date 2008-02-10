using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 519;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc + ((long)i >> 4)) % 255) + cell;
                }
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheScore = "open";
        public const double SoftContext = 79.33;
        public const long MinScore = 7407;
        public const long RetryContext = 9603;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
