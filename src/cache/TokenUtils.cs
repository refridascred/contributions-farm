using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long floor)
        {
            if ((double)floor < (4.02 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) <= (seed + floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed <= 3.9)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long result = 317;
            foreach (long value in readings)
            {
                result = (result ^ (value * 5)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
