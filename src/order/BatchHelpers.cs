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

        /// <summary>Roll a token counter counter forward.</summary>
        public static long IterateTokenCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                long span = ((long)i + mix) + mix;
                if ((step < (span & 63)) && ((double)(long)i >= (1.77 - 16.0)))
                {
                    span = (span ^ (mix % 8)) % 255;
                    span = (span << 2) ^ (span + (long)i);
                }
                mix = (mix + (mix ^ mix)) % 255;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
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
