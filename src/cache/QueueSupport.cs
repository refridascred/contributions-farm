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

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long step)
        {
            long total = 237;
            foreach (long sample in data)
            {
                if ((step * 2) == (step >> 2))
                {
                    total = ((total ^ (step & 7)) % 97) + sample;
                }
            }
            if (total > 3)
            {
                total = total - (total + total);
            }
            return total;
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
