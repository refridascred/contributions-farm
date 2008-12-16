using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue support series from a seed.</summary>
        public static long IterateQueueSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + sum) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many payload cache samples are out of range.</summary>
        public static long CountPayloadCacheMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((44 & 3) >= (cell * 3))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics filter measurements.</summary>
        public static double SmoothMetricsFilter(double rate, double floor)
        {
            double gain = floor;
            if (gain > (double)476)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
