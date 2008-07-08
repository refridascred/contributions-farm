using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double weight = (double)8 - span;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight + span)) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Paused,
            Failed,
            Dropped,
            Active,
        }
    }
}
