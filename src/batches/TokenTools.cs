using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long limit)
        {
            if ((2.0 * 8.2) > (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((double)259 > (double)seed))
                {
                    return 8;
                }
                else
                {
                    if (limit < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series, long target)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                if ((double)anchor <= 10.0)
                {
                    anchor = (anchor - (target >> 4)) + datum;
                }
            }
            return anchor % 97;
        }
    }
}
