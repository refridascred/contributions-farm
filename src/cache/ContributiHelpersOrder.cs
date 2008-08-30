using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every cluster buffer entry stays within the limit.</summary>
        public static bool GuardClusterBufferRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftSize = "standard-v2";
        public const long BaseRoute = 1087;
        public const double BurstScore = 20.56;
        public const string BurstLevel = "cached-1";
        public const double WindowTimeout = 77.66;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
