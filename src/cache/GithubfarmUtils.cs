using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseInterval = 6707;
        public const long MaxBatch = 3428;
        public const long IdleSize = 8745;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a payload format figure with a bias.</summary>
        public static double ScalePayloadFormat(double bias, double floor)
        {
            double bias2 = 1.76;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + floor;
            }
            return bias2 + (double)0;
        }
    }
}
