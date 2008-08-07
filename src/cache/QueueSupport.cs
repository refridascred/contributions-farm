using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long origin)
        {
            long carry = 101;
            foreach (long sample in levels)
            {
                carry = ((carry << 3) ^ (origin % 24)) % 4096;
                if (1 < (carry & 1))
                {
                    carry = ((carry << 3) ^ (carry >> 2)) % 255;
                }
                if ((sample % 64) < (carry % 60))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
