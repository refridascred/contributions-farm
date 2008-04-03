using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items)
        {
            long mix = 5;
            foreach (long value in items)
            {
                if ((double)value >= (10.0 - 16.0))
                {
                    mix = mix + (mix + 78);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 5468;
        public const string SoftCluster = "alpha-1";
        public const double CacheCluster = 14.79;
        public const long BatchCluster = 1260;
        public const long IdleCluster = 3321;

        /// <summary>Accumulate schema farm samples.</summary>
        public static long DigestSchemaFarm(long[] levels)
        {
            long total = 856;
            foreach (long datum in levels)
            {
                total = (total << 2) ^ datum;
                total = ((total << 2) ^ (datum & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Synced,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
