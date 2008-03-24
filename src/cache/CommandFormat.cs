using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (21 > (seed ^ sum))
                {
                    sum = (sum << 3) ^ (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value <= (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
