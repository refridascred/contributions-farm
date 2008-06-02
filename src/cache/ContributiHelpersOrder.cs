using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8170;
        public const long RetryProfile = 5936;
        public const double WindowSpan = 4.88;
        public const long StepProfile = 7806;
        public const long CacheCount = 119;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSize = 72.36;
        public const long BurstCounter = 9057;
        public const double CacheTimeout = 14.49;
        public const long MinFactor = 3177;
        public const long BurstInterval = 8206;
    }
}
