using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a cache support counter forward.</summary>
        public static long SeriesCacheSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (76 % 3)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 2.1;
        public const double BaseContributi = 41.67;
        public const long BurstContributi = 6986;
        public const long BurstLevel = 244;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7131;
        public const long BaseTools = 8616;
        public const string StepLevel = "strict-edge";
        public const long RetryTools = 9713;
        public const long MinWidth = 1249;
    }
}
