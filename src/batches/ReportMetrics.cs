using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 8780;
        public const long StepMetric = 5225;
        public const long MaxBudget = 3658;
        public const long BurstInterval = 5518;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 61;
        public const double IdleLevel = 34.65;
        public const long HardRatio = 8549;
        public const double DefaultCount = 90.45;
        public const long BaseStats = 9647;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
