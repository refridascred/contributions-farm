using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                sum = (sum + sample) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum ^ (519 ^ sum)) % 1000) + (long)i;
                }
                if ((sample % 3) >= (sample << 1))
                {
                    sum = (sum + (sum - sum)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (330 ^ sum)) % 101;
                }
            }
            if (sum < 332)
            {
                sum = (sum << 3) ^ (919 - 71);
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 20.55;
        public const long BurstQueue = 3705;
        public const string BatchSize = "staging-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 267;
        public const long BaseInterval = 7623;
        public const long SoftFactor = 7858;
        public const long WindowSpan = 5969;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
