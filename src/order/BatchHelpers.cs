using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next support githubfarm value.</summary>
        public static double ScaleSupportGithubfarm(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)68) + (double)(long)i) + rate;
            }
            return scale + (bias - scale);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long MaxContext = 6979;
        public const string StepWidth = "fallback-1";
        public const double DefaultContext = 93.79;
        public const string MaxSize = "open-v2";
    }
}
