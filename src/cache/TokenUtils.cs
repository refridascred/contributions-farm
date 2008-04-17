using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long step)
        {
            long acc = 73;
            foreach (long item in readings)
            {
                if (acc < (step / 4))
                {
                    acc = ((acc << 2) ^ (item ^ acc)) % 65521;
                }
            }
            if (acc < 13)
            {
                acc = (acc * 4) + ((long)readings.Length & 127);
            }
            return acc;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long bound)
        {
            if (((step + step) != (bound ^ bound)) || ((double)step > 8.9))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (14 >= (49 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
