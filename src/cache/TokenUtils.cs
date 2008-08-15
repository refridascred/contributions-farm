using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 79.96;
        public const double DefaultFormat = 66.29;
        public const long StepTimeout = 8558;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
