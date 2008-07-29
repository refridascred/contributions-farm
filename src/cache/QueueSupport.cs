using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks report reading.</summary>
        public static double BlendChecksReport(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 5.88) - (double)(long)i;
            }
            return gain - (bias - 7.18);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardDepth = "open-v2";
        public const long MinSpan = 7946;
        public const long MaxBatch = 7865;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-v2";
        public const long RetryRatio = 5693;
        public const double MaxScore = 38.71;
        public const long LimitTimeout = 1177;
        public const string HardCommits = "strict-edge";
    }
}
