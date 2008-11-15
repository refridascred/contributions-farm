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

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long total = -823;
            foreach (long value in series)
            {
                total = ((total * 2) + (seed & 63)) % 101;
                if (((value + value) == (seed / 5)) || ((102 + total) < (value * 5)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series, long bound)
        {
            long sum = -859;
            foreach (long sample in series)
            {
                sum = ((sum ^ (bound * 5)) % 4096) ^ sample;
            }
            return sum;
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
