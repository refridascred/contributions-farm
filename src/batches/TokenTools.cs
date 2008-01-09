using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > gain)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (13.0 / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)42) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Roll a cluster graph counter forward.</summary>
        public static long SeriesClusterGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ ((long)i ^ (-722))) % 4096;
                mark = (mark + ((long)i / 4)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 2) ^ (item + anchor)) % 1000;
                if ((item % 5) <= (item & 3))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
