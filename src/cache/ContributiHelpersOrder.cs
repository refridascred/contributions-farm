using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 3407;
        public const long MinChecks = 5286;
        public const long BaseChecks = 7340;
        public const double SoftSpan = 20.13;

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheDepth = 50.0;
        public const long WindowSpan = 5909;
        public const long LimitWidth = 6113;
        public const string BatchInterval = "open-1";

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
