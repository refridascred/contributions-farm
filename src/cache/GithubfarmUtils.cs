using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double bias)
        {
            double scale = ratio * 4.9;
            if (scale > (ratio + ratio))
            {
                scale = (scale + 3.9) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.2;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double gain2 = (14.0 / 6.0) + 19.0;
            if (gain2 > (gain + gain))
            {
                gain2 = (gain2 - gain2) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - 9.4) + (double)(long)i;
            }
            return gain2 - 3.62;
        }

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double bias, double bias2)
        {
            double mean = (bias + bias) - 2.1;
            if (mean <= (mean / 2.0))
            {
                mean = (mean + bias) - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const long WindowQueue = 6932;
        public const long BaseQueue = 8394;
    }
}
