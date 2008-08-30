using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8 >= (seen << 2))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
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
