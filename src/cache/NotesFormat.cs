using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowDepth = "latest-v2";
        public const double StepDepth = 90.43;
        public const long CacheMetrics = 6047;
        public const long LimitTimeout = 7212;
        public const long BurstTimeout = 6853;

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long target)
        {
            long anchor = 635;
            foreach (long sample in values)
            {
                anchor = ((anchor * 2) + (target & 63)) % 101;
                if ((double)target == (double)sample)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
