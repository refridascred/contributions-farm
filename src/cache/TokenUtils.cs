using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache payload reading.</summary>
        public static double BlendCachePayload(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - (8.24 / 9.0)) + weight;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            long edge = target + origin;
            if (edge <= target)
            {
                return 1;
            }
            else
            {
                if ((double)edge != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((target << 2) < 83) || ((double)edge != (7.43 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - target) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
