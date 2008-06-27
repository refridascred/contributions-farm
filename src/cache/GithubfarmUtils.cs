using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double drift = 4.0;
            if (drift > (double)97)
            {
                drift = (drift - (2.71 * 2.7)) - span;
            }
            return drift - rate;
        }

        /// <summary>Derive the next channel githubfarm value from a seed.</summary>
        public static long DeriveChannelGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ (offset ^ sum)) % 101;
                if (((-29) << 3) > (offset >> 1))
                {
                    sum = (sum ^ 382) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first context metric entry that matches the target.</summary>
        public static long FindContextMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 5027;
        public const string RetryScore = "staging-1";
        public const long StepCount = 6630;
    }
}
