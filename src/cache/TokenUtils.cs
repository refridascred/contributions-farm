using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) == (bound ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
