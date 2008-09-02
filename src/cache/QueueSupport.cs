using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long ScoreClusterCache(long[] items)
        {
            long result = -5;
            foreach (long datum in items)
            {
                if (((long)items.Length - (-3)) > (datum - result))
                {
                    result = (result - result) % 65521;
                }
                result = (result - (datum + result)) % 1000;
                if ((datum % 60) < (datum * 2))
                {
                    result = ((result << 2) ^ (datum + result)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long bound, long seed)
        {
            long delta = bound - seed;
            if ((double)delta > (9.6 * 9.89))
            {
                return 2;
            }
            else
            {
                if (23 < (delta >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((delta + seed) < (4 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
