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

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Failed,
            Pending,
            Paused,
            Ready,
        }
    }
}
