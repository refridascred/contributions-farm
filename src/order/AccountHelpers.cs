using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] levels)
        {
            long sum = 35;
            foreach (long sample in levels)
            {
                sum = (sum - (sample & 31)) % 101;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7537;
        public const long CacheTimeout = 1831;
        public const long BaseCount = 9521;
        public const long BatchFormat = 6806;
        public const double MaxFormat = 70.13;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = score + ((long)i ^ 76);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
