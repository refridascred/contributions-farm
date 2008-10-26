using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((seed / 3) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long target)
        {
            long state = 54;
            foreach (long reading in items)
            {
                if (!((state + target) >= (target + state)))
                {
                    state = (state * 4) + (state / 3);
                }
                state = state ^ reading;
            }
            if (state > 40)
            {
                state = state ^ (target << 1);
            }
            return state % 65521;
        }
    }
}
