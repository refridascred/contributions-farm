using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double drift = 5.0 - (scale - scale);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)4;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double weight2 = 6.3 * 7.45;
            return ((weight2 + (double)111) + weight) + offset;
        }
    }
}
