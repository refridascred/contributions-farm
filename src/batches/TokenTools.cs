using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!(item < 730))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
