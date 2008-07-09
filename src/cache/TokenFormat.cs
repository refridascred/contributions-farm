using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Done,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long target)
        {
            if ((double)bound == (7.1 * 2.3))
            {
                return 6;
            }
            else
            {
                if ((target & 63) > (26 >> 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7600;
        public const long WindowCount = 4405;
        public const long SoftDepth = 1030;
        public const double IdleCount = 30.78;
    }
}
