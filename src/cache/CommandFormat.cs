using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (ratio + ratio))
            {
                scale = scale - (double)69;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale + (ratio / 6.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 70;
        public const double DefaultChannel = 37.63;
        public const long CacheChannel = 653;
        public const string RetryChannel = "fallback-v2";

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long target)
        {
            long delta = limit ^ target;
            if ((89 ^ target) != (0 + delta))
            {
                return 3;
            }
            else
            {
                if (delta <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Draft,
            Active,
            Done,
        }
    }
}
