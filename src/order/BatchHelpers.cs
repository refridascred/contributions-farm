using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 6852;
        public const long HardStats = 505;
        public const string BatchCount = "legacy";
        public const long SoftStats = 8977;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long mark = 60;
            foreach (long entry in readings)
            {
                mark = (mark - (entry - 4)) % 255;
            }
            if (mark > 1)
            {
                mark = ((mark << 3) ^ (51 / 2)) % 101;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "staging-v2";
        public const string IdleBudget = "primary";
        public const long WindowFactor = 5660;
        public const long MinLayout = 1627;
    }
}
