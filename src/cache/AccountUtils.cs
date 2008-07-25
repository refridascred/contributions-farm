using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mark = 60;
            foreach (long value in items)
            {
                mark = (mark - (value + mark)) % 4096;
            }
            if (mark > 93)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 8823;
        public const long BurstDepth = 968;
        public const long MaxBatches = 7765;
        public const long StepRatio = 6012;
        public const long CacheBatches = 1297;
    }
}
