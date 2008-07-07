using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items, long step)
        {
            long total = 57;
            foreach (long value in items)
            {
                if ((total - 7) >= (total + 7))
                {
                    total = ((((total * 4) + total) % 1000) - value) - step;
                }
            }
            return total % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinDepth = "fallback-v2";
        public const long BatchCommand = 3189;
        public const long MaxCommand = 3635;
        public const string StepInterval = "local-v2";

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double load = (double)((-6) - 81);
            if (load >= (ratio * 8.5))
            {
                load = (load - (double)0) + floor;
            }
            return load - load;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3575;
        public const string WindowWidth = "primary";
        public const long BaseFactor = 1840;
        public const long StepEntry = 3807;
        public const string RetryEntry = "strict-edge";

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((839 + target) >= mix))
                {
                    mix = (mix ^ ((long)i / 9)) % 97;
                }
                mix = (mix - (6 % 5)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
