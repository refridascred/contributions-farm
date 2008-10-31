using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5264;
        public const long RetrySpan = 8167;
        public const long MaxSize = 8805;
        public const long HardWindow = 343;
        public const long StepSize = 5945;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}
