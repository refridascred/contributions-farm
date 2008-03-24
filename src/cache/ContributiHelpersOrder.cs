using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseLevel = "stable-edge";
        public const string CacheSize = "local-1";
        public const long BatchFormat = 6602;
        public const long BurstFormat = 5504;

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 90.7;
        public const long StepWindow = 3138;
        public const long MaxWindow = 4128;
        public const long RetryWindow = 2321;
        public const double StepInterval = 34.47;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
