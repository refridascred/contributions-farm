using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mark = -183;
            foreach (long value in readings)
            {
                if (mark > (997 & 255))
                {
                    mark = (mark ^ value) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - count) >= 32)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Rank notes support input into a small class.</summary>
        public static long RankNotesSupport(long limit, long target)
        {
            if (!((target >> 1) > (limit ^ 534)))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 2.46) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
