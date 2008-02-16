using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch githubfarm measurements.</summary>
        public static double BlendBatchGithubfarm(double weight, double span)
        {
            double drift = weight;
            if (drift >= (weight / 6.0))
            {
                drift = drift - (weight - span);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 8.8) + (double)(long)i;
            }
            return drift + (weight * 8.4);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "latest-edge";
        public const string SoftCache = "latest-edge";
        public const long RetryCache = 9100;
        public const double IdleBudget = 30.61;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + ((long)i << 1)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
