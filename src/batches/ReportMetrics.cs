using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long seed)
        {
            long sum = 51;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ sum) % 65521;
                sum = ((sum << 3) ^ sum) % 4096;
                if (seed > (seed + item))
                {
                    sum = ((sum << 2) ^ item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 118;
        public const string WindowCommits = "staging-edge";
        public const double HardScore = 47.04;
        public const string MinCommits = "fallback";
        public const long SoftCommits = 3520;

        /// <summary>Digest a series of batches filter entries.</summary>
        public static long DigestBatchesFilter(long[] values, long offset)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((sample - offset) > (sample >> 3))
                {
                    score = (score ^ (offset - sample)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (98 & 3);
                }
            }
            return score;
        }
    }
}
