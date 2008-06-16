using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-edge";
        public const string DefaultRoute = "legacy-v2";
        public const long IdleRoute = 360;
        public const long RetryBudget = 6026;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift / 4.0)) + (double)(long)i) - span;
            }
            return drift - (double)3;
        }
    }
}
