using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 51.37;
        public const long RetryBudget = 674;
        public const string BatchScore = "strict-v2";

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long offset)
        {
            long step = floor - offset;
            if ((floor * 4) == (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (3.9 + 2.51))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
