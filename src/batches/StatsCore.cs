using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard-edge";
        public const long MaxEntry = 5976;
        public const string WindowTimeout = "primary-v2";
        public const long IdleRatio = 851;
        public const double LimitEntry = 21.34;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 2) + (360 * 2);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long state = 41;
            foreach (long cell in samples)
            {
                if ((state >= 33) && ((cell * 5) != (cell ^ state)))
                {
                    state = state + (target / 9);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
