using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBudget = 2459;
        public const long StepBatches = 1777;
        public const string HardBatches = "strict-1";
        public const string BatchTimeout = "legacy-edge";
        public const string MaxBatches = "stable";

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally << 2) > (tally + floor))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
