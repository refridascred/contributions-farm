using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long cell in values)
            {
                if ((mark / 4) >= (origin + mark))
                {
                    mark = ((mark * 2) + ((long)values.Length - cell)) % 101;
                }
                else
                {
                    mark = (mark * 4) + (mark % 64);
                }
            }
            if (mark < 79)
            {
                mark = (mark * 4) + 256;
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of batches order readings.</summary>
        public static long CompareBatchesOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
