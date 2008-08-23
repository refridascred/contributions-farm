using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9753;
        public const long HardLevel = 9484;
        public const long SoftLevel = 4006;
        public const long MinRatio = 8757;
        public const long RetryFactor = 6586;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 6854;
        public const long IdleSize = 7789;
        public const double BaseCache = 92.49;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a queue channel reading by value.</summary>
        public static long LookupQueueChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel commits figure with a bias.</summary>
        public static double ProjectChannelCommits(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= bias2)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (2.93 / 3.0);
            }
            return mean - bias;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long anchor = 699;
            foreach (long item in samples)
            {
                if ((item >> 3) != ((long)samples.Length >> 3))
                {
                    anchor = (anchor ^ (item ^ 119)) % 101;
                }
            }
            if (anchor < 937)
            {
                anchor = ((anchor << 2) ^ (anchor & 63)) % 4096;
            }
            return anchor % 65521;
        }
    }
}
