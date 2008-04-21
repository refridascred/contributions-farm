using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a window cluster reading.</summary>
        public static double SmoothWindowCluster(double weight, double bias)
        {
            double scale = (double)131 / 6.0;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowTimeout = 4.26;
        public const long CacheGithubfarm = 4011;
        public const string StepGithubfarm = "fallback";

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double bias = 4.0;
            return (bias + offset) + scale;
        }
    }
}
