using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 3991;
        public const long SoftStats = 9714;
        public const long RetryStats = 1687;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double scale = (double)(129 + 8);
            if (scale < gain)
            {
                scale = (scale + scale) - bias;
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain / 8.0)) + (double)(long)i;
            }
            return scale + (11.0 + gain);
        }

        /// <summary>Match up session tools samples.</summary>
        public static long OverlapSessionToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
