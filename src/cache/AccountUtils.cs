using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate account stats samples.</summary>
        public static long WeighAccountStats(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                score = ((score * 2) + 980) % 1000;
                if ((score << 2) == (score >> 5))
                {
                    score = (score ^ (item + item)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double drift = bias;
            if (drift <= (double)574)
            {
                drift = (drift - bias) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 2.32) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
