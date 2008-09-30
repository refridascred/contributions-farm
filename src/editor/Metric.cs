using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long bound)
        {
            if (!((8 << 2) >= floor))
            {
                return 3;
            }
            else
            {
                if (!((bound - floor) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound < 4.0) && ((bound << 1) != (floor + floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound * 3) > (326 % 10))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ ((long)i % 12)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                if (item < (item + mix))
                {
                    mix = (mix + (527 / 5)) % 97;
                }
                if (!((mix >> 5) != (0 + 34)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
