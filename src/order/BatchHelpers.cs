using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            long slot = bound - floor;
            if (3.4 > (double)slot)
            {
                return 6;
            }
            else
            {
                if ((slot & 63) == (6 / 3))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 85.12;
        public const double RetrySupport = 62.49;
        public const double DefaultSpan = 16.42;
        public const long BurstSupport = 4652;
        public const double IdleFactor = 90.57;
    }
}
