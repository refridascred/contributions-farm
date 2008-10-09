using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain < (double)25)
            {
                gain = (gain - bias) - weight;
            }
            return gain - (double)404;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings)
        {
            long anchor = 305;
            foreach (long item in readings)
            {
                if ((double)item <= (1.66 * 4.3))
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
                if ((long)readings.Length >= (anchor % 97))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
