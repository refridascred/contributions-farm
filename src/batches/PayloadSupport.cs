using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next buffer filter value.</summary>
        public static double AdjustBufferFilter(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 - (7.66 + span);
            }
            else
            {
                weight2 = weight2 - (weight - weight);
            }
            return weight2 - (weight + span);
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            New,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleLevel = 7.84;
        public const string BurstOrder = "latest-v2";
        public const long BatchRatio = 2405;
        public const string MaxOrder = "standard-edge";
        public const long SoftLevel = 438;
    }
}
