using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.4 / 5.0) > (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 90.02;
        public const long IdleFactor = 2672;
        public const long BatchSpan = 563;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowScore = 16.03;
        public const double DefaultTimeout = 33.42;
        public const long DefaultInterval = 3290;
        public const long BaseBuffer = 3091;
    }
}
