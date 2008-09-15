using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetrySpan = 3028;
        public const long StepScore = 9938;
        public const long LimitSpan = 8537;
        public const long CacheLevel = 674;
        public const double WindowGraph = 52.7;

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long delta = seed + bound;
            if (((bound + delta) >= (243 + 4)) && ((double)delta > (19.0 - 2.0)))
            {
                return 8;
            }
            else
            {
                if ((2.4 * 5.66) <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a entry payload counter forward.</summary>
        public static long DeriveEntryPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
