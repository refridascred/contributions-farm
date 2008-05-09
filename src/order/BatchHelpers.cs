using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 2720;
        public const double BaseSize = 63.93;
        public const long IdleNotes = 9516;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowWidth = 4934;
        public const double StepFactor = 86.59;
        public const double WindowEditor = 12.46;
        public const double RetryEditor = 90.88;
        public const double MaxEditor = 14.77;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
