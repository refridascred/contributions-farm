using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items, long offset)
        {
            long acc = 17;
            foreach (long reading in items)
            {
                acc = ((((acc << 3) ^ 663) % 101) + reading) - offset;
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((sum + sum) > (origin - 73))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long OverlapStatsCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
