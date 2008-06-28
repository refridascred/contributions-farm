using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two batches profile measurements.</summary>
        public static double SmoothBatchesProfile(double ratio, double floor)
        {
            double load = ratio;
            if (load >= ratio)
            {
                load = (load + (ratio + ratio)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 18.0) - (double)(long)i;
            }
            return load + (double)2;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftRatio = 5656;
        public const long BatchRatio = 680;
        public const long IdleSpan = 6427;
        public const string StepCount = "alpha-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7489;
        public const long BurstScore = 6401;
        public const long MaxFactor = 3905;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long total = -257;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 5)) % 101;
                if (!((entry & 127) < total))
                {
                    break;
                }
            }
            if (total < 312)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
