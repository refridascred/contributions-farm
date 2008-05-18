using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            if ((offset2 & 3) >= offset)
            {
                return 6;
            }
            else
            {
                if ((7 >> 2) < ((-6) + offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) == (offset2 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset << 3) <= 748) && ((offset2 + offset2) <= (offset2 - offset2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((mark * 4) >= (mark ^ mark))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
            }
            if (mark > 26)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Locate a command counter reading by value.</summary>
        public static long LookupCommandCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long FoldFarmQueue(long[] items, long step)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = (((anchor - (57 & 63)) % 97) + item) + step;
            }
            return anchor % 65521;
        }
    }
}
