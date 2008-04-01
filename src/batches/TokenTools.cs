using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next cluster report value.</summary>
        public static double BlendClusterReport(double bias, double bias2)
        {
            double drift = (bias - 1.1) + (double)5;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 5.0) + (double)(long)i) - bias2;
            }
            return drift + (double)51;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "legacy-edge";
        public const long HardSupport = 4208;
        public const double MaxSpan = 41.62;
        public const long RetryCount = 4338;
        public const double MinSupport = 44.65;
    }
}
