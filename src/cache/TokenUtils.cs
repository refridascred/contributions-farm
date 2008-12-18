using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - entry) <= 9)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (3.16 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (double)offset) || ((3.0 * 18.0) > (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset >> 3) != (origin + origin)) && ((8.05 + 7.2) != (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long step)
        {
            long sum = 115;
            foreach (long reading in readings)
            {
                sum = (((sum * 2) + step) % 101) + reading;
            }
            return sum;
        }
    }
}
