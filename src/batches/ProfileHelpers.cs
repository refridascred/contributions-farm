using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((origin + (long)i) > (8 - mark)))
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long ScoreBatchReport(long[] levels)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                if (((reading + mix) <= ((long)levels.Length ^ mix)) || (reading <= (69 + mix)))
                {
                    mix = (mix + (reading * 4)) % 101;
                }
                else
                {
                    mix = (mix - (mix ^ 9)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = mix - 8;
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long bound)
        {
            if (0 <= limit)
            {
                return 0;
            }
            else
            {
                if (bound <= (581 - bound))
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) > 155)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheDepth = 4898;
        public const long BatchLayout = 8857;
        public const long DefaultLayout = 580;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total - 4) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
