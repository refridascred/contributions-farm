using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxWidth = 25.93;
        public const double BurstSession = 89.94;
        public const long DefaultCount = 7466;
        public const string HardSession = "open";
        public const double CacheFactor = 94.39;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double drift = bias2 - bias;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (7.26 + bias2)) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - seen) != (seen + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
