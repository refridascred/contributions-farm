using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double scale = (double)24 - bias;
            if (scale < (0.5 - scale))
            {
                scale = (scale + (double)3) + rate;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (scale * 19.0);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell <= (478 - count))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Adjust a queue graph reading.</summary>
        public static double ScaleQueueGraph(double gain, double offset)
        {
            double load = (double)((-14) / 3);
            if (load <= (double)(-1))
            {
                load = (load - (offset * 2.46)) + gain;
            }
            return load - offset;
        }
    }
}
