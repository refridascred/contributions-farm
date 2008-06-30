using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((target / 5) == (sum ^ sum))
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                    break;
                }
                if (sum > (item & 31))
                {
                    sum = sum - (-50);
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine entry route values into a single score.</summary>
        public static long ScoreEntryRoute(long[] items, long offset)
        {
            long mix = -759;
            foreach (long cell in items)
            {
                if (((long)items.Length + 186) <= cell)
                {
                    mix = mix + (cell ^ offset);
                }
                if (((cell + mix) >= ((-156) + cell)) && ((8.5 * 4.8) <= (7.0 + 1.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ ((long)i / 5)) % 255;
                if (((double)(long)i < (double)bound) && (7.4 <= (double)(long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
