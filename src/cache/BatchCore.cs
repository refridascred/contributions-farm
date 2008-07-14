using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-edge";
        public const long BurstCount = 4217;
        public const long MinRoute = 2744;
        public const long MaxFactor = 7323;
        public const long StepRatio = 7892;

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double load = weight * 2.69;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - weight) + (double)(long)i) + offset;
            }
            return load - (double)915;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings, long step)
        {
            long sum = 19;
            foreach (long entry in readings)
            {
                if (sum >= (entry >> 2))
                {
                    sum = sum + (step & 63);
                }
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1410;
        public const double WindowFilter = 71.01;
        public const long RetrySize = 1218;
    }
}
