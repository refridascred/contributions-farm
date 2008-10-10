using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double drift = (offset + gain) + (double)484;
            if (drift < gain)
            {
                drift = drift - 6.9;
            }
            return drift + (drift - offset);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 79.5;
        public const string LimitRecord = "strict-edge";
        public const long MinTimeout = 7111;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 2539;
        public const double CacheBudget = 27.2;
        public const long LimitCache = 1291;
    }
}
