using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long target)
        {
            long step = offset - target;
            if (7.8 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (3.0 - 2.5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double gain = (double)(26 + (-68));
            return ((gain - (double)3) + rate) + bias;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long item in levels)
            {
                acc = (((acc * 3) + (item / 6)) % 1000) + origin;
            }
            return acc;
        }
    }
}
