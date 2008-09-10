using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 5) + offset;
                if ((offset + offset) < anchor)
                {
                    anchor = (anchor - (offset * 4)) % 101;
                }
                else
                {
                    anchor = anchor ^ (318 % 16);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double gain = ratio * 17.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + 0.22) + (double)(long)i) - bias;
            }
            return gain - gain;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
            Draft,
        }
    }
}
