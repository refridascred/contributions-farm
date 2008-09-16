using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long mix = 7;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + (mix + mix)) + datum;
            }
            return mix;
        }

        /// <summary>Look up the position of a token stats sample.</summary>
        public static long FindTokenStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long origin)
        {
            long score = 6;
            foreach (long cell in values)
            {
                if ((score - score) == (score + cell))
                {
                    score = (score ^ (cell * 5)) % 65521;
                }
                if (((score ^ 485) <= (score + origin)) || (49 > score))
                {
                    score = ((score << 3) ^ cell) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
