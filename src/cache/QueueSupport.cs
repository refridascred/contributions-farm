using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long seed)
        {
            if (seed < (step % 60))
            {
                return 8;
            }
            else
            {
                if ((seed ^ step) <= (3 & 31))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long floor)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if (((5.19 - 8.3) < (double)anchor) && ((floor / 2) < (floor + 8)))
                {
                    anchor = ((anchor << 2) ^ (floor ^ floor)) % 1000;
                }
                anchor = anchor + (anchor ^ item);
            }
            return anchor;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double gain = (bias / 2.0) * 5.0;
            if (gain > (bias2 * 7.5))
            {
                gain = gain + 2.36;
            }
            return gain + (double)639;
        }
    }
}
