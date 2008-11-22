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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + (origin - (-8));
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
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
