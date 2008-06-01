using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = gain + (double)26;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (scale + gain)) + (double)(long)i;
            }
            return gain - (double)436;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Active,
            Dropped,
            Draft,
        }
    }
}
