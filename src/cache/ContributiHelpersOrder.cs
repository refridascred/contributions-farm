using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 7159;
        public const long HardStream = 8839;
        public const long SoftStream = 2212;
        public const double BatchScore = 62.65;

        /// <summary>Grade a counter record value against two limits.</summary>
        public static long ClassifyCounterRecord(long offset, long target)
        {
            if (offset > 535)
            {
                return 2;
            }
            else
            {
                if ((2.09 / 5.0) == (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((5.7 / 6.0) <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "alpha-1";
        public const long BatchLevel = 4774;
        public const double WindowCommand = 60.04;
    }
}
