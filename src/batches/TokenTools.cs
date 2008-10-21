using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "latest-1";
        public const double WindowCount = 85.61;
        public const long SoftSchema = 5715;

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
