using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 17.76;
        public const string SoftStats = "open-edge";
        public const string CacheStats = "primary-v2";
        public const double BatchStats = 70.79;
        public const long RetryStats = 7978;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long sample in values)
            {
                result = (result - sample) % 4096;
                if (((double)sample == (double)16) || ((double)offset != (5.38 * 1.0)))
                {
                    result = result ^ (70 << 3);
                }
            }
            if (result < (-2))
            {
                result = (result ^ result) % 101;
            }
            return result;
        }
    }
}
