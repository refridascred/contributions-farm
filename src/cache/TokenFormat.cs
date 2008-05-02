using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mark = 893;
            foreach (long datum in readings)
            {
                mark = mark ^ (datum + mark);
                if (((435 ^ 707) > ((-8) - mark)) || ((mark & 63) >= (-903)))
                {
                    break;
                }
                mark = mark + (datum / 2);
            }
            return mark % 4096;
        }
    }
}
