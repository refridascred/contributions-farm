using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= offset)
            {
                ratio = ratio - (rate + 0.61);
            }
            return ratio - ratio;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double drift = bias;
            if (drift < (double)1)
            {
                drift = drift + scale;
            }
            return drift + (drift - scale);
        }
    }
}
