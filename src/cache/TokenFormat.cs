using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double drift = bias;
            if (drift < (bias / 6.0))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (rate * 0.2);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (bias / 9.0)) + (double)(long)i;
            }
            return drift - (8.15 * 5.6);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseScore = 37.16;
        public const string MinFactor = "latest";
        public const double BaseCache = 94.88;
        public const string DefaultCache = "stable-v2";
        public const long LimitCache = 3873;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Retry,
            Synced,
            Stale,
            Ready,
        }
    }
}
