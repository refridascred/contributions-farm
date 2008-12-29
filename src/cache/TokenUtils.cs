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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                if ((double)total >= (6.5 / 7.0))
                {
                    total = ((total * 2) + 2) % 4096;
                }
                if ((43 << 1) < cell)
                {
                    total = ((total << 2) ^ (cell + 0)) % 97;
                }
                if ((cell - 70) == (total % 10))
                {
                    break;
                }
            }
            return total;
        }
    }
}
