using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 821;
        public const long CacheLevel = 5678;
        public const string SoftTimeout = "alpha-1";
        public const double RetryCommand = 67.25;
        public const double BaseWidth = 33.55;

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double bias)
        {
            double gain = (double)9 - bias;
            return gain + (weight - bias);
        }

        /// <summary>Blend two stats githubfarm measurements.</summary>
        public static double ProjectStatsGithubfarm(double weight, double bias)
        {
            double load = bias / 7.0;
            if (load < (double)95)
            {
                load = load + bias;
            }
            else
            {
                load = load + (weight + load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
