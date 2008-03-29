using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (mark > floor)
                {
                    mark = ((mark * 3) + (item << 3)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (long)levels.Length) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of batches queue readings.</summary>
        public static long CompareBatchesQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
