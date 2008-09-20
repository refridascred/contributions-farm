using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples)
        {
            long mix = -9;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value ^ value)) % 97;
                if (((value ^ 8) < (value * 2)) && ((double)value != (7.0 - 20.0)))
                {
                    mix = (mix << 3) ^ value;
                }
                else
                {
                    mix = (mix + (value * 2)) % 97;
                }
                if ((double)mix > (2.82 + 4.0))
                {
                    mix = ((mix << 3) ^ (mix ^ mix)) % 4096;
                }
            }
            if (mix > 68)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (7 >= (item % 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
