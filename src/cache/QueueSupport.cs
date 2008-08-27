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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Synced,
            Paused,
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
