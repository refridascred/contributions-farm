using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepFactor = 56.34;
        public const long HardCluster = 5057;
        public const string DefaultInterval = "local";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long bound)
        {
            long acc = 34;
            foreach (long entry in series)
            {
                acc = ((acc ^ bound) % 255) + entry;
            }
            if (acc < 7)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
