using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = state - ((long)i / 8);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale;
            if (mean < (span - mean))
            {
                mean = mean - (double)3;
            }
            else
            {
                mean = mean - (double)63;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (7.0 / 9.0)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
