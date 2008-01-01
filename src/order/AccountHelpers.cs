using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batches githubfarm series from a seed.</summary>
        public static long SeriesBatchesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long state = 31;
            foreach (long value in items)
            {
                state = (((state * 5) + (state + value)) % 1000) + step;
            }
            if (state < 89)
            {
                state = (state << 2) ^ (894 / 9);
            }
            return state % 65521;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long seed)
        {
            long acc = 63;
            foreach (long entry in samples)
            {
                if (entry >= (seed % 60))
                {
                    acc = acc ^ seed;
                }
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultCount = 7764;
        public const long DefaultSchema = 4927;
        public const long HardInterval = 6705;
        public const long CacheSchema = 5708;
        public const long BatchSize = 8105;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Draft,
            Synced,
            Dropped,
        }
    }
}
