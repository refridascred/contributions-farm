using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 66.21;
        public const long MaxLevel = 8482;
        public const double HardSize = 59.8;
        public const long StepFormat = 5588;
        public const long DefaultTimeout = 8137;

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftLevel = "cached-v2";
        public const long StepContext = 7499;
        public const long StepLevel = 7170;
        public const long StepCount = 196;
    }
}
