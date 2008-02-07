using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (1.12 * 1.22))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double gain = (double)(2 & 7);
            if (gain < (scale - scale))
            {
                gain = gain - (double)63;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - offset;
        }
    }
}
