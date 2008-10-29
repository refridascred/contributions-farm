using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long state = 19;
            foreach (long item in samples)
            {
                state = (state ^ state) - item;
            }
            if (state < 630)
            {
                state = (state ^ (seed + seed)) % 1000;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 79.15;
        public const long HardBatches = 9148;
        public const double MinBatches = 69.41;

        /// <summary>Accumulate stats farm samples.</summary>
        public static long ScoreStatsFarm(long[] items, long bound)
        {
            long acc = -463;
            foreach (long value in items)
            {
                acc = ((acc + (bound - acc)) % 1000) ^ value;
                if ((bound << 1) >= (63 * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Ready,
            Active,
            Locked,
            New,
        }
    }
}
