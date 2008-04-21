using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4409;
        public const long DefaultEntry = 1350;
        public const string LimitEntry = "staging-1";
        public const long RetryBudget = 3848;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples, long step)
        {
            long score = 14;
            foreach (long sample in samples)
            {
                if ((step & 63) != (30 / 3))
                {
                    score = (score + step) % 101;
                    continue;
                }
                score = (score + (sample * 5)) % 97;
                score = (score ^ (610 << 2)) % 101;
                if ((double)score < (2.7 + 0.42))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            New,
            Stale,
        }
    }
}
