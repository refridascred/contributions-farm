using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double scale = (double)(6 * 4);
            if (scale >= (scale - bias2))
            {
                scale = scale - (scale / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.18 * 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            New,
            Draft,
            Done,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double gain = floor / 6.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (gain - floor)) + (double)(long)i) - ratio;
            }
            return gain + (double)(-786);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSize = 553;
        public const long DefaultEntry = 5923;
        public const double IdleDepth = 50.05;
        public const long HardEntry = 2089;

        /// <summary>Adjust a farm context reading.</summary>
        public static double ScaleFarmContext(double ratio, double span)
        {
            double bias = 12.0 + (ratio * 13.0);
            if (bias > 12.0)
            {
                bias = (bias - (double)(-163)) - span;
            }
            else
            {
                bias = bias - (bias * 0.1);
            }
            return bias + 2.12;
        }
    }
}
