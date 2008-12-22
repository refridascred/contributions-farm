using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 3) ^ floor) % 97;
                    result = result ^ ((long)i2 + (long)i2);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2.8 / 3.0) < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long bound, long step)
        {
            if (((step - bound) < step) || ((bound + step) >= (76 & 3)))
            {
                return 7;
            }
            else
            {
                if (8 <= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((8.5 - 0.9) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
