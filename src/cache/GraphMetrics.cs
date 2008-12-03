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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
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
