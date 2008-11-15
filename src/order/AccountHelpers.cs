using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstDepth = 2475;
        public const double MaxSpan = 36.58;
        public const long CacheGithubfarm = 9311;
        public const long RetryGithubfarm = 4384;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 3) + (carry + (long)i)) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long score = 558;
            foreach (long cell in items)
            {
                score = (score - (score + cell)) - origin;
            }
            return score;
        }
    }
}
