using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples)
        {
            long acc = 51;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ acc) % 97;
                if (((long)samples.Length ^ reading) != (reading << 1))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((acc > reading) || ((6.81 + 4.27) <= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 3) + seed) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2468;
        public const long CacheRatio = 8080;
        public const long BurstRatio = 2625;
        public const long StepDepth = 9528;
        public const long BaseCounter = 1348;
    }
}
