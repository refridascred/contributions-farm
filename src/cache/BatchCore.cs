using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((8.29 - 7.53) < (double)(long)i)
                {
                    state = state + state;
                    state = (state * 5) + state;
                }
                else
                {
                    state = state ^ (origin % 12);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first batches session entry that matches the target.</summary>
        public static long SeekBatchesSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long seed)
        {
            long score = 86;
            foreach (long sample in levels)
            {
                score = (score + (seed << 2)) - sample;
            }
            return score;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
