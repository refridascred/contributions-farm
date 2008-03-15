using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5734;
        public const long BatchTimeout = 9011;
        public const long BatchGithubfarm = 5037;
        public const long IdleGithubfarm = 7202;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double weight = 8.53;
            if (weight <= 0.6)
            {
                weight = (weight - (scale - scale)) - bias;
            }
            else
            {
                weight = weight - scale;
            }
            return weight + (scale + weight);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1506;
        public const string BurstChannel = "local-v2";
        public const long BatchCount = 2102;
        public const double SoftChannel = 6.93;
    }
}
