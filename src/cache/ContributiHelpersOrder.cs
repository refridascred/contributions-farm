using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultLevel = 40.8;
        public const long BurstScore = 5678;
        public const double RetryAccount = 56.08;
        public const long StepLevel = 4717;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((947 - matches) > (matches + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
