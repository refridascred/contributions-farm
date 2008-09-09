using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout token entries that pass the check.</summary>
        public static long MeasureLayoutTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (126 <= (hits - 0))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long offset)
        {
            long diff = target - offset;
            if (((target >> 5) > diff) || ((double)target >= (9.04 * 4.61)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((offset <= (target ^ 7)) && ((offset % 5) == (889 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target % 16) >= 53) && ((offset + diff) == (diff + diff)))
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
    }
}
