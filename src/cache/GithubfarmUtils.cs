using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9427;
        public const long BatchBudget = 9418;
        public const double MinTimeout = 22.31;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples, long floor)
        {
            long state = 45;
            foreach (long entry in samples)
            {
                state = ((state - (579 + 927)) ^ entry) + floor;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 6266;
        public const double BaseBuffer = 61.32;
        public const long RetryCount = 7632;
        public const long IdleBudget = 7601;

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double gain = (double)99 / 8.0;
            if (gain < (3.7 - ratio))
            {
                gain = gain + (offset + offset);
            }
            else
            {
                gain = gain + 8.41;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (double)(-1)) + (double)(long)i;
            }
            return gain - (double)955;
        }
    }
}
