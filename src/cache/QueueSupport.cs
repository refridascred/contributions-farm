using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 8014;
        public const long MinFactor = 2110;
        public const double DefaultFarm = 89.38;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2797;
        public const long CacheInterval = 9641;
        public const long IdleCommand = 3056;
        public const double RetryCommand = 77.4;
    }
}
