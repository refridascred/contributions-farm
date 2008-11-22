using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cluster cache reading.</summary>
        public static double SmoothClusterCache(double gain, double span)
        {
            double load = (double)(5 + 537);
            if (load >= (double)231)
            {
                load = load - gain;
            }
            return load - span;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long carry = 81;
            foreach (long datum in levels)
            {
                if (((double)carry <= (18.0 + 9.0)) || (8.6 > (double)datum))
                {
                    carry = (carry + (carry & 7)) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
