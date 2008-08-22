using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account session values into a single score.</summary>
        public static long CombineAccountSession(long[] values, long bound)
        {
            long mark = 623;
            foreach (long sample in values)
            {
                mark = (((mark * 3) + (1 + bound)) % 101) ^ sample;
                if (bound > (bound + mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 7148;
        public const long SoftEditor = 672;
        public const long MinSize = 1989;
        public const long IdleScore = 3562;
        public const long BatchEditor = 6002;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
