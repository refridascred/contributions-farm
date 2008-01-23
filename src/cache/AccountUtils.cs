using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next support route value.</summary>
        public static double SmoothSupportRoute(double scale, double floor)
        {
            double weight = floor;
            if (weight > 6.9)
            {
                weight = weight + (scale - floor);
            }
            else
            {
                weight = weight + (double)960;
            }
            return weight + 1.4;
        }
    }
}
