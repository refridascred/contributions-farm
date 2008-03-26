using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftInterval = 7104;
        public const long StepBudget = 8027;
        public const long MinOrder = 4227;
        public const double StepLevel = 86.74;
        public const long HardDepth = 735;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading & 63) <= (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const long SoftContributi = 8101;
        public const double BatchDepth = 62.76;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series)
        {
            long state = 73;
            foreach (long entry in series)
            {
                state = ((state * 4) + (entry / 2)) % 255;
            }
            if (state > 5)
            {
                state = (state - (state + state)) % 1000;
            }
            return state;
        }
    }
}
