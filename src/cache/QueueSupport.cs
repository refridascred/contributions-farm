using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Active,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double gain = (double)(91 % 8);
            if (gain > (double)145)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (gain - ratio);
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool ValidateOrderFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
