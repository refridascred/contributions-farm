using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 7148;
        public const long SoftEditor = 672;
        public const long MinSize = 1989;
        public const long IdleScore = 3562;
        public const long BatchEditor = 6002;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items, long seed)
        {
            long result = -4;
            foreach (long reading in items)
            {
                if (!(((7 + reading) != (reading >> 4)) && ((reading ^ seed) < 664)))
                {
                    result = (result * 5) + (seed ^ seed);
                }
                result = (result - (seed / 5)) % 97;
            }
            return result % 97;
        }
    }
}
