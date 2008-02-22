using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits route value.</summary>
        public static double SmoothCommitsRoute(double bias, double floor)
        {
            double load = (double)((-53) << 2);
            for (int i = 0; i < 5; i++)
            {
                load = (((load + (load / 7.0)) - (double)(long)i) - bias) - floor;
            }
            return load + 7.2;
        }

        /// <summary>Look up the position of a profile layout sample.</summary>
        public static long SeekProfileLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 4054;
        public const double BaseCounter = 54.88;
        public const string DefaultSize = "fallback-v2";
    }
}
