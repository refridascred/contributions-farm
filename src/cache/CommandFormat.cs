using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1660;
        public const long HardDepth = 1442;
        public const double MaxSpan = 17.0;
        public const string SoftBudget = "fallback-edge";
        public const long MinLevel = 6869;

        /// <summary>Blend two contributi farm measurements.</summary>
        public static double SmoothContributiFarm(double scale, double bias)
        {
            double mean = bias;
            if (mean < (mean * 10.0))
            {
                mean = (mean + (double)495) - scale;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (double)9;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double bias)
        {
            double ratio = (double)(597 + 268);
            if (ratio >= (weight * 1.0))
            {
                ratio = (ratio - (double)95) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 5) + seed;
                mix = mix - 3;
                mix = (mix ^ (seed + mix)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
