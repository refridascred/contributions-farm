using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if ((mark >> 4) < (2 / 2))
                {
                    mark = (mark ^ (mark ^ mark)) ^ datum;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Done,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 284;
        public const long MaxGithubfarm = 5886;
        public const long MaxInterval = 8851;
        public const double RetryGithubfarm = 58.8;
        public const string IdleTimeout = "cached-1";

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double drift = 17.0 - bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 6.76) - (double)(long)i) + scale;
            }
            return drift + 1.06;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
