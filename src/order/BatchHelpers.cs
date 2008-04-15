using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (long)i) % 255;
                if ((((long)i - 15) > (score & 127)) || ((55 - score) != ((long)i % 24)))
                {
                    score = (score ^ (seed * 2)) % 4096;
                    score = ((score * 3) + (seed & 15)) % 1000;
                    continue;
                }
                score = score - (long)i;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every profile checks entry stays within the limit.</summary>
        public static bool GuardProfileChecksRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
