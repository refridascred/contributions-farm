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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (16.0 + 5.6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long step)
        {
            if ((double)step != (1.5 - 18.0))
            {
                return 5;
            }
            else
            {
                if (((step - step) <= (538 + step)) || ((limit << 3) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step < (19.0 - 4.84)) || ((limit - step) == (step ^ step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
