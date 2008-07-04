using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long CombineContributiCluster(long[] items)
        {
            long mark = 32;
            foreach (long datum in items)
            {
                mark = (mark + 42) + datum;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 9453;
        public const string IdleSize = "standard-edge";
        public const double HardSchema = 3.85;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double bias)
        {
            double ratio = (bias + gain) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)639) + (double)(long)i;
            }
            return ratio - (double)(-4);
        }
    }
}
