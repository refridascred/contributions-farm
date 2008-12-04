using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((20.0 * 1.9) > (double)(long)i)
                {
                    acc = (acc * 2) + offset;
                }
                else
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first window batches entry that matches the target.</summary>
        public static long FindWindowBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
