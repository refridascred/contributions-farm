using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Dropped,
            New,
            Active,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items)
        {
            long score = 110;
            foreach (long datum in items)
            {
                score = (score << 3) ^ (datum * 5);
                score = ((score * 4) + (score & 15)) % 1000;
            }
            if (score > 1)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if (!(sum > (3 >> 4)))
                {
                    sum = (((sum + (546 ^ sum)) % 101) - reading) - bound;
                }
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 46.67;
        public const long RetryTimeout = 5814;
        public const string BatchSpan = "primary-edge";

        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool ValidateBatchesRecordLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
