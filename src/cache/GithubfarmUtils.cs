using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchInterval = 21.73;
        public const long RetryScore = 3745;
        public const long IdleCluster = 5812;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double span)
        {
            double load = bias;
            if (load <= (load * 8.3))
            {
                load = (load - (double)67) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 8.3) + (double)(long)i;
            }
            return load + (8.0 - bias);
        }
    }
}
