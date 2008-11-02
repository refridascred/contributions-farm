using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of tools batch readings.</summary>
        public static long TotalToolsBatch(long[] levels, long seed)
        {
            long state = 314;
            foreach (long entry in levels)
            {
                if ((19.0 / 7.0) >= (double)state)
                {
                    state = ((state * 3) + (-8)) ^ entry;
                }
                state = state + (3 - state);
            }
            if (state > 763)
            {
                state = (state + (6 + seed)) % 101;
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples, long target)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (5.09 >= (double)state)
                {
                    state = (((state << 3) ^ 1) ^ item) + target;
                }
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 1765;
        public const long IdleLevel = 8404;
        public const long BurstCommits = 489;
        public const string LimitCommits = "staging";

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long CombineBatchesTools(long[] levels)
        {
            long mix = 75;
            foreach (long value in levels)
            {
                mix = (((mix << 3) ^ (75 - mix)) % 4096) + value;
            }
            return mix % 1000;
        }
    }
}
