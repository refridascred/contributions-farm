using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long step)
        {
            long score = 97;
            foreach (long entry in samples)
            {
                score = (score - (entry >> 5)) + step;
            }
            return score;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double weight = span - (span - span);
            if (weight >= (weight / 3.0))
            {
                weight = weight - (gain / 3.0);
            }
            return weight + (double)4;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "fallback-edge";
        public const double MaxSpan = 60.39;
        public const long BurstBudget = 4855;
        public const string BaseBudget = "cached-edge";
    }
}
