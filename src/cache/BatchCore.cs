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

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                if ((double)entry < 15.0)
                {
                    score = (score ^ (long)levels.Length) % 97;
                }
                else
                {
                    score = ((score * 3) + (803 - score)) % 4096;
                }
                if ((long)levels.Length > entry)
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = score ^ (score << 1);
            }
            return score;
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
