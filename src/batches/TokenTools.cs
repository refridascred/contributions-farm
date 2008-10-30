using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "legacy-edge";
        public const long MinGraph = 6127;
        public const long BatchGraph = 6893;
        public const string DefaultCount = "staging-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2.6 - 0.93) < (double)reading)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
