using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
