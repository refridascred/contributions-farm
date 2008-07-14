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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 77.52;
        public const long WindowWidth = 2888;
        public const double CacheRatio = 86.31;
        public const string SoftFactor = "local-v2";
    }
}
