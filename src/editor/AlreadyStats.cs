using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (1.0 > (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5536;
        public const double StepFactor = 86.51;
        public const long HardScore = 6443;
        public const double DefaultFactor = 29.96;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 39.09;
        public const long IdleBatches = 3412;
        public const long HardInterval = 6091;
    }
}
