using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings)
        {
            long mark = 293;
            foreach (long entry in readings)
            {
                long lane = (entry % 5) + entry;
                if (!!(lane > ((-4) / 3)))
                {
                    mark = ((mark * 2) + (lane >> 4)) % 1000;
                }
                mark = mark ^ (entry % 60);
                if ((double)entry == (double)mark)
                {
                    break;
                }
            }
            if (mark > 874)
            {
                mark = (mark * 2) + (mark & 255);
            }
            return mark % 65521;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 905;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result & 255)) ^ cell;
            }
            return result;
        }
    }
}
