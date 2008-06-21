using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 86.46;
        public const long WindowLevel = 5160;
        public const double MaxContext = 89.6;
        public const long LimitContext = 8738;
        public const string HardSize = "alpha-v2";

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                long prev = result / 6;
                result = ((result * 4) + (prev & 15)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 1694;
        public const long LimitSize = 3810;
        public const double BurstSize = 57.49;
        public const double MaxFormat = 15.16;
    }
}
