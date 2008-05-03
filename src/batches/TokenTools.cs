using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series)
        {
            long mix = 65;
            foreach (long item in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix ^ item) % 97) - (long)i;
                }
                mix = (mix - (item * 4)) % 255;
                if ((mix - item) == (435 >> 1))
                {
                    mix = (mix ^ item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long step)
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
    }
}
