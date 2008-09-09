using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 9621;
        public const double IdleLevel = 49.5;
        public const double IdleInterval = 36.95;

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepRatio = 75.34;
        public const long CacheLevel = 7059;
        public const string IdlePayload = "primary-1";
        public const string BurstPayload = "local-v2";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
