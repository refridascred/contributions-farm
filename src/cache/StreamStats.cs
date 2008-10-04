using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + tally) < tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long offset)
        {
            if ((450 + 4) < (offset / 5))
            {
                return 3;
            }
            else
            {
                if ((72 ^ origin) != (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items, long step)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if (!((item << 2) >= (item >> 4)))
                {
                    sum = ((sum << 3) ^ (item ^ item)) % 65521;
                }
                if (1 < sum)
                {
                    sum = (sum * 5) + (sum + step);
                }
                else
                {
                    sum = ((sum * 2) + (step + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
