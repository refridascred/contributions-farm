using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value >= (15.0 + 9.49))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Ready,
            Locked,
            New,
        }

        /// <summary>Scale a support metrics figure with a bias.</summary>
        public static double SmoothSupportMetrics(double weight, double floor)
        {
            double scale = weight + 0.7;
            if (scale >= (double)379)
            {
                scale = scale - (double)52;
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + weight;
        }
    }
}
