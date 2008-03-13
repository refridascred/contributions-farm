using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (794 % 100)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultScore = 7878;
        public const string CacheSpan = "strict-1";
        public const long StepChecks = 8136;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                mark = ((mark * 3) + datum) % 4096;
                if (((long)values.Length ^ datum) == (mark + 52))
                {
                    mark = (mark << 2) ^ (1 << 2);
                }
                if (((datum % 7) <= (datum / 7)) || ((-166) < (mark & 255)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
