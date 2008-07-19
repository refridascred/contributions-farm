using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long total = 1;
            foreach (long cell in readings)
            {
                total = ((total << 2) ^ (total & 127)) % 1000;
                if ((total & 127) < (total / 6))
                {
                    total = (total << 2) ^ total;
                }
                if ((cell - cell) > total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
