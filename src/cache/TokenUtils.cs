using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long acc = 86;
            foreach (long reading in series)
            {
                if ((acc ^ reading) >= (acc % 12))
                {
                    acc = acc - (6 & 7);
                }
            }
            return acc;
        }

        /// <summary>Adjust a checks profile reading.</summary>
        public static double SmoothChecksProfile(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= (1.6 - 6.6))
            {
                weight = weight + (double)70;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
