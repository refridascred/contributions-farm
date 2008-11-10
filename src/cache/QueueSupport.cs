using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if ((acc + acc) == (reading - reading))
                {
                    acc = (acc ^ (reading % 16)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound != (9.0 * 9.1))
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
