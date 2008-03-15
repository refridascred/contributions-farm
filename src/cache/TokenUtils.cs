using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)seen != (8.3 / 4.0)) || ((19.0 + 7.64) >= (double)seen)) && ((value / 3) >= (1 + value)))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Match up tools batches samples.</summary>
        public static long OverlapToolsBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
