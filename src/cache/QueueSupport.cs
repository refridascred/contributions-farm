using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchCount = 92.55;
        public const double DefaultProfile = 83.41;
        public const long WindowSize = 6094;
        public const long IdleInterval = 1097;
        public const long BurstBudget = 6476;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster githubfarm value.</summary>
        public static double ProjectClusterGithubfarm(double gain, double offset)
        {
            double ratio = 4.93;
            if (ratio < (offset / 8.0))
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio + (gain / 4.0);
        }
    }
}
