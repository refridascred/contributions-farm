using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next context githubfarm value.</summary>
        public static double SmoothContextGithubfarm(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)347) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Paused,
            New,
            Draft,
        }
    }
}
