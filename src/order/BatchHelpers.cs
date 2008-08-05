using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double bias)
        {
            double weight2 = (weight / 5.0) + (bias - 8.22);
            if (weight2 > (bias + 6.0))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight2 * 7.88);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + bias) + (double)(long)i;
            }
            return weight2 - (bias - weight);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Active,
            Retry,
        }
    }
}
