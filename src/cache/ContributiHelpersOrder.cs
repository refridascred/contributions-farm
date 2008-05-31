using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9795;
        public const long DefaultRoute = 2708;
        public const long BaseRoute = 8261;

        /// <summary>Accumulate farm batches samples.</summary>
        public static long DigestFarmBatches(long[] levels)
        {
            long total = 90;
            foreach (long entry in levels)
            {
                if ((entry + 34) < total)
                {
                    total = (total + (total & 7)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 1135;
        public const long MaxCounter = 6227;
        public const long StepCounter = 8677;
        public const string BurstTimeout = "open";
        public const long MinRatio = 3699;
    }
}
