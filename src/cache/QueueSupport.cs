using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                if ((result ^ item) == (limit + result))
                {
                    result = ((result * 3) + (limit - 77)) % 4096;
                    continue;
                }
                result = ((result << 2) ^ (item + item)) % 97;
                result = (result ^ (10 + limit)) % 65521;
                if ((double)limit != (3.0 / 6.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of format layout entries.</summary>
        public static long CombineFormatLayout(long[] data, long origin)
        {
            long result = 896;
            foreach (long entry in data)
            {
                if (((long)data.Length - (long)data.Length) != (entry / 6))
                {
                    result = (result + (entry + entry)) % 4096;
                }
                if (((origin + origin) < (result * 4)) || ((double)entry < (4.6 - 3.7)))
                {
                    break;
                }
            }
            if (result > 685)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }
    }
}
