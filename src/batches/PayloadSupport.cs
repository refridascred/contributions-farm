using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] samples, long offset)
        {
            long mix = 69;
            foreach (long datum in samples)
            {
                mix = (((mix ^ mix) % 1000) - datum) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double load = weight;
            if (load < weight)
            {
                load = (load + (double)108) - offset;
            }
            else
            {
                load = load + 6.0;
            }
            return load - 6.06;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
