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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
