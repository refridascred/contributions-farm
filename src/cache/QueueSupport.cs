using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a notes buffer reading.</summary>
        public static double SmoothNotesBuffer(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 + (double)90;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum ^ seed) % 1000;
                sum = sum - (seed - seed);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
