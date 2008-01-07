using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            if (((-888) ^ seed) != (floor - seed))
            {
                return 8;
            }
            else
            {
                if (((double)seed != (2.0 + 6.89)) && ((double)seed == (6.0 - 0.27)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long floor)
        {
            long mix = -123;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ ((-536) + (long)samples.Length)) % 255;
                if (((cell * 3) >= (mix / 7)) || ((mix * 4) >= (mix >> 3)))
                {
                    mix = (mix - (7 + 440)) % 1000;
                }
                else
                {
                    mix = (mix - (cell ^ floor)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((53 + 599) != (origin - result))
                {
                    result = result ^ (result % 64);
                }
                else
                {
                    result = ((result << 2) ^ (5 ^ result)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
