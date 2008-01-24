using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3455;
        public const long RetryBudget = 651;
        public const long MaxInterval = 2567;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if (((origin % 97) >= (origin + offset)) && ((offset >> 5) > origin))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) != (9 + origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
