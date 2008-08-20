using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (32 + mark)) % 101;
                mark = (mark + (mark % 24)) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine route buffer values into a single score.</summary>
        public static long ScoreRouteBuffer(long[] items, long seed)
        {
            long mix = 860;
            foreach (long cell in items)
            {
                if (((7.7 / 5.0) != (double)mix) || ((seed - 694) > (seed >> 5)))
                {
                    mix = ((mix + (seed & 7)) % 4096) + cell;
                }
            }
            return mix;
        }
    }
}
