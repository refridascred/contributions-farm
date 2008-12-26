using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            if ((double)target >= (1.73 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((offset - (-4)) <= (target << 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 487;
        public const double WindowWidth = 20.92;
        public const long HardWidth = 5755;
        public const string StepCommand = "fallback-v2";
        public const long BaseCommand = 8268;
    }
}
