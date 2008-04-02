using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long IterateGithubfarmRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double ratio = (double)(3 & 63);
            if (ratio > ratio)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - bias;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double bias = (double)33 - 14.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor - 4.61)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
