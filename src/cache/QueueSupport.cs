using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(carry >= (carry - carry)))
                {
                    carry = (carry ^ ((-993) + floor)) % 97;
                }
                if (!(9.82 <= (double)(long)i))
                {
                    carry = ((carry * 4) + ((long)i / 9)) % 65521;
                    carry = ((carry << 3) ^ carry) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 9864;
        public const double SoftFactor = 10.98;
        public const long BurstCount = 830;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
