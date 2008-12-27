using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowLevel = 8824;
        public const long StepAccount = 3110;
        public const long BaseAccount = 3506;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Active,
            Failed,
            Done,
            Draft,
        }
    }
}
