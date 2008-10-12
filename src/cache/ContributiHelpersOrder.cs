using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardWidth = 10.45;
        public const long RetryCache = 4809;
        public const long HardCache = 11;
        public const string HardCount = "latest";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7508;
        public const string IdleCluster = "cached";
        public const long BatchCluster = 4414;
        public const long MaxCluster = 606;
        public const string BatchFactor = "latest";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
