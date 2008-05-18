using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entry entries.</summary>
        public static long TotalQueueEntry(long[] series, long offset)
        {
            long result = 48;
            foreach (long entry in series)
            {
                result = (result * 4) + (entry ^ offset);
            }
            if (result < 8)
            {
                result = (result + (offset + result)) % 101;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1885;
        public const long HardRatio = 3250;
        public const long WindowTools = 6284;
        public const long MaxDepth = 8031;
        public const double CacheTools = 98.91;
    }
}
