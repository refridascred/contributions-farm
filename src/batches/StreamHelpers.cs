using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels, long seed)
        {
            long carry = 356;
            foreach (long datum in levels)
            {
                carry = (carry * 4) + (seed - datum);
            }
            if (carry > 10)
            {
                carry = (carry << 3) ^ 6;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if (((double)(long)samples.Length == (double)cell) && ((sum ^ sum) <= cell))
                {
                    sum = ((sum << 2) ^ (sum + cell)) % 4096;
                }
                else
                {
                    sum = sum - (cell + 70);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleLevel = 25.42;
        public const long BurstMetrics = 9547;
        public const long HardSpan = 8302;
        public const double BaseInterval = 50.46;

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheBudget = "stable-v2";
        public const long MinEntry = 5153;
        public const long LimitLevel = 4810;
        public const long BatchEntry = 5759;
        public const long BaseEntry = 4485;

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long DigestClusterEntry(long[] items, long limit)
        {
            long acc = 987;
            foreach (long entry in items)
            {
                if (((double)limit < (0.64 - 3.99)) || ((double)acc <= (double)limit))
                {
                    acc = (acc - (long)items.Length) % 1000;
                }
                if ((double)acc > (19.0 + 7.0))
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ (6 / 4)) % 97;
            }
            return acc;
        }
    }
}
