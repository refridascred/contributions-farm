using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleInterval = 20.58;
        public const long MaxCommits = 4600;
        public const string BurstInterval = "staging";
        public const string HardCommits = "fallback-edge";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!(((50 + value) < (46 - value)) || ((double)value == (5.0 / 7.0))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ (527 ^ step);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
