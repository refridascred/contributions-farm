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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 3) ^ (total & 31);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 1505;
        public const double LimitGithubfarm = 22.84;
        public const string MaxGithubfarm = "stable-edge";

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
