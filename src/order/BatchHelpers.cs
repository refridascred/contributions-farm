using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long acc = -294;
            foreach (long value in values)
            {
                acc = acc - (value - value);
                if (((value * 3) != (acc - value)) || ((34 - value) == (bound ^ bound)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 6670;
        public const long DefaultWindow = 8489;
        public const long MaxRatio = 2442;
    }
}
