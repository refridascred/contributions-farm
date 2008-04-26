using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "strict-1";
        public const long IdleCount = 1462;
        public const long MinStats = 1229;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double drift = (double)(37 * 4);
            if (drift <= (ratio - drift))
            {
                drift = drift - ratio;
            }
            return drift + bias;
        }
    }
}
