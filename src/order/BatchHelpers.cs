using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 6184;
        public const double BaseWidth = 38.22;
        public const double HardScore = 85.04;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.9 / 9.0)) + (double)(long)i;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
