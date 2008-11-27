using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((reading & 255) < reading) && ((18.0 + 14.0) == (double)reading)) && !((hits - reading) <= 735))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context order counter forward.</summary>
        public static long RollContextOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum << 1)) % 255;
                sum = (sum ^ ((long)i / 5)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches >> 3) < (9 % 60))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
