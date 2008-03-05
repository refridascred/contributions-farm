using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double weight = (bias * 14.0) + (double)248;
            if (weight > 11.0)
            {
                weight = (weight + weight) + gain;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            return weight + bias;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate cache context readings against a bound.</summary>
        public static bool GuardCacheContextBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
