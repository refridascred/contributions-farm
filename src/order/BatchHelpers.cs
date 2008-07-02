using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes route entries.</summary>
        public static long FoldNotesRoute(long[] items, long seed)
        {
            long result = 4;
            foreach (long datum in items)
            {
                if ((0.53 - 1.68) >= (double)result)
                {
                    result = (((result << 3) ^ (seed - seed)) % 97) - datum;
                }
            }
            return result;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Locate a cache profile reading by value.</summary>
        public static long FindCacheProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
