using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double gain = span;
            if (gain > (double)659)
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 397;
        public const long CacheSize = 2703;
        public const double MaxRatio = 52.79;
        public const long StepOrder = 9310;
        public const long MaxCount = 9852;

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor * 5.22)) + (double)(long)i;
            }
            return mean + (double)782;
        }
    }
}
