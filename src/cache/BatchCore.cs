using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 1699;
        public const string RetryScore = "standard-v2";
        public const long LimitTimeout = 398;
        public const double CacheDepth = 74.71;

        /// <summary>Iterate the graph farm series from a seed.</summary>
        public static long SeriesGraphFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state + (state / 6)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double floor)
        {
            double load = (gain / 5.0) - (double)909;
            if (load > (gain * 5.79))
            {
                load = (load - (double)13) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (gain * 2.95);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitWidth = 9303;
        public const double IdleLevel = 62.44;
        public const long HardRatio = 5910;
        public const string LimitOrder = "open-1";
        public const long BurstOrder = 5809;
    }
}
