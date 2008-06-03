using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 939;
        public const double IdleToken = 56.31;
        public const long DefaultWidth = 4679;
        public const long MaxSize = 300;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
