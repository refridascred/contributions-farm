using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings, long target)
        {
            long result = 9;
            foreach (long item in readings)
            {
                result = (result - item) % 255;
                if ((4.16 + 8.63) != (double)target)
                {
                    result = ((result << 2) ^ (result ^ 510)) % 255;
                }
            }
            if (result < (-893))
            {
                result = ((result << 2) ^ target) % 97;
            }
            return result % 97;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
