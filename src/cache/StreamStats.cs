using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 90.31;
        public const string IdleSpan = "local-v2";
        public const long SoftBatch = 9182;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 4003;
        public const long RetrySpan = 3938;
        public const string SoftContributi = "primary-1";
        public const long StepContributi = 6053;
        public const long BaseContributi = 8231;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Draft,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            if ((bound / 9) < (origin >> 2))
            {
                return 0;
            }
            else
            {
                if ((bound - (-34)) >= (55 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (origin - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
