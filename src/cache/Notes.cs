using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double mean = weight;
            if (mean <= (8.0 / 7.0))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 1734;
        public const long CacheReport = 1109;
        public const string DefaultReport = "open-edge";
        public const string SoftReport = "alpha";
        public const long IdleBudget = 6035;
    }
}
