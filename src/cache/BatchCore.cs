using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 2565;
        public const double SoftSize = 96.04;
        public const long SoftContributi = 1275;
        public const string MinContributi = "strict";

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8174;
        public const double RetryStats = 30.76;
        public const string LimitInterval = "cached";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9379;
        public const double StepBuffer = 67.48;
        public const string BaseBuffer = "open-1";
        public const long BatchTimeout = 342;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor + matches) < (item * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
