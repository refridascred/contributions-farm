using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultCount = 2006;
        public const long DefaultFilter = 1868;
        public const string BatchFilter = "strict-v2";
        public const long MaxCount = 7124;

        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double span)
        {
            double rate = (double)((-8) ^ (-581));
            for (int i = 0; i < 4; i++)
            {
                rate = (((rate + (double)(-307)) + (double)(long)i) + ratio) - span;
            }
            return rate - (5.91 * 3.48);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleScore = 7565;
        public const double StepTimeout = 76.04;
        public const string IdleSession = "fallback-edge";
        public const long BurstSession = 706;
    }
}
