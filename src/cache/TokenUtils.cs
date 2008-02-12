using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 40.95;
        public const string LimitCount = "local-v2";
        public const string RetryCount = "cached-1";

        /// <summary>Count the githubfarm cluster entries that pass the check.</summary>
        public static long TallyGithubfarmClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((9.0 / 3.0) == (double)hits) || !((entry * 4) <= 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
