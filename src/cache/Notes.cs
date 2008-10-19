using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next account notes value.</summary>
        public static double AdjustAccountNotes(double scale, double bias)
        {
            double scale2 = (double)(5 - 14);
            if (scale2 > (scale - 1.0))
            {
                scale2 = (scale2 + (double)(-49)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale2 * 8.0)) - (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3370;
        public const double CacheLevel = 95.58;
        public const double BaseRatio = 43.93;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a filter report value against two limits.</summary>
        public static long BucketFilterReport(long origin, long origin2)
        {
            if ((origin >> 3) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((0.61 / 9.0) != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (402 / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.7 * 2.92) == (double)origin) && (origin < (526 + 733)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor filter samples.</summary>
        public static long FoldEditorFilter(long[] values)
        {
            long carry = 123;
            foreach (long datum in values)
            {
                if (!((carry + carry) < 16))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                if (((carry & 255) < carry) || ((carry + datum) >= (carry << 1)))
                {
                    carry = (carry - (9 >> 4)) % 97;
                }
            }
            return carry % 1000;
        }
    }
}
