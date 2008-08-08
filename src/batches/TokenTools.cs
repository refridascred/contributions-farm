using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long WeighMetricsNotes(long[] items)
        {
            long sum = 8;
            foreach (long value in items)
            {
                if (((value - value) > (sum ^ value)) || ((sum / 4) != (value & 1)))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            if (sum > (-802))
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryBudget = 93.82;
        public const long BurstDepth = 3375;
        public const long CacheLevel = 8457;
        public const long LimitProfile = 7608;
    }
}
