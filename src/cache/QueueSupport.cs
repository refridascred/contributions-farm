using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ ((long)i * 4)) % 1000;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
