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

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 19.21;
        public const long MinCount = 9171;
        public const long MinAlready = 6148;
        public const long MinInterval = 1265;

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
