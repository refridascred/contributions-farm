using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm metrics samples are out of range.</summary>
        public static long CountGithubfarmMetricsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((bound > seen) && ((double)seen != (double)(long)samples.Length)) || ((item >> 3) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Idle,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Failed,
            Active,
        }
    }
}
