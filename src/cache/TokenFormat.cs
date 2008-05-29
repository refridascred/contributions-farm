using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long bound)
        {
            if ((834 % 97) != (bound + seed))
            {
                return 3;
            }
            else
            {
                if ((30 ^ seed) >= (seed & 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.9 * 1.0) <= (double)count)
                {
                    count = ((count + 2) ^ cell) + step;
                }
            }
            return count;
        }
    }
}
