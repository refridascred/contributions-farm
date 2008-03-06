using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 9248;
        public const string DefaultWidth = "alpha-edge";
        public const long DefaultBatch = 4240;
        public const string IdleBatch = "strict-v2";

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double scale = (double)(602 & 127);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - (scale / 3.0)) + (double)(long)i) + rate) + bias;
            }
            return scale - (double)112;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
