using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a checks contributi figure with a bias.</summary>
        public static double BlendChecksContributi(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset + 1.0)) + (double)(long)i;
            }
            return mean - (mean + scale);
        }

        /// <summary>Accumulate entry format samples.</summary>
        public static long TotalEntryFormat(long[] levels)
        {
            long mark = 971;
            foreach (long cell in levels)
            {
                mark = mark ^ mark;
                mark = (mark ^ (mark ^ cell)) % 65521;
                if (((cell - (long)levels.Length) > (4 - cell)) && ((mark + mark) < (8 + 12)))
                {
                    mark = (mark - (long)levels.Length) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((target & 1) > origin)
            {
                return 7;
            }
            else
            {
                if (target > 20)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
