using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = -671;
            foreach (long sample in values)
            {
                acc = (acc ^ (49 - acc)) ^ sample;
                if (acc < (acc - acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftSize = 3497;
        public const double BurstTimeout = 39.44;
        public const double IdleToken = 36.32;
        public const long MinToken = 88;
        public const long SoftTimeout = 1963;
    }
}
