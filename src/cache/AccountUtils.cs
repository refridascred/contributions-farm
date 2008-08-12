using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double gain, double floor)
        {
            double scale = gain + gain;
            return (scale - gain) + floor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((18.0 + 2.03) <= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double weight = 5.0;
            if (weight <= (weight - gain))
            {
                weight = weight + (span * 13.0);
            }
            return weight + gain;
        }
    }
}
