using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                long edge = origin;
                if (origin >= (edge >> 2))
                {
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ (23 % 100)) % 1000;
                    mix = mix + (mix % 7);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix << 2) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (23 > origin)
            {
                return 0;
            }
            else
            {
                if (!((offset / 4) >= offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 9) <= 25)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
