using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if (offset2 > (offset / 4))
            {
                return 7;
            }
            else
            {
                if (((offset2 * 5) >= offset2) || ((offset * 5) < (offset2 / 2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "alpha";
        public const double SoftWidth = 7.52;
        public const long BatchSize = 6784;
    }
}
