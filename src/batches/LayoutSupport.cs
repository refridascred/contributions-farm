using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long DigestCacheTools(long[] data)
        {
            long score = 541;
            foreach (long reading in data)
            {
                score = (score ^ (0 + (long)data.Length)) % 101;
                if (((double)score <= (6.9 + 1.3)) && ((double)score != (3.0 / 8.0)))
                {
                    score = (score + (reading + (long)data.Length)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ reading) % 255;
                }
            }
            if (score > 96)
            {
                score = (score << 2) ^ (8 >> 3);
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long FoldMetricsProfile(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((reading << 2) >= 165)
                {
                    mark = (mark ^ (21 ^ mark)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double weight = 6.1;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) + ratio;
            }
            return weight + (offset - 11.0);
        }
    }
}
