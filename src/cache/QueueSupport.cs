using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long result = 1;
            foreach (long entry in series)
            {
                result = (result + (limit + entry)) % 4096;
                if (!((double)entry >= 14.0))
                {
                    result = result ^ limit;
                }
                if ((limit % 2) <= 24)
                {
                    break;
                }
            }
            if (result > 847)
            {
                result = ((result * 4) + (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Queued,
            Ready,
        }
    }
}
