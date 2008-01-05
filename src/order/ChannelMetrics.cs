using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 7180;
        public const long WindowRatio = 6977;
        public const double HardBatches = 5.24;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit + total) == (limit >> 1))
                {
                    total = (total ^ total) % 255;
                }
                else
                {
                    total = (total << 3) ^ (limit + total);
                    total = (total - total) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double load = ratio;
            if (load < floor)
            {
                load = load + (double)92;
            }
            return load + (load - 1.02);
        }
    }
}
