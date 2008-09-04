using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long SortSchemaContributi(long step, long offset)
        {
            if ((double)offset != (14.0 + 8.3))
            {
                return 2;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    if (33 > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.6 * 1.74) != (double)offset) || ((step + offset) >= (offset - step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1588;
        public const long StepLevel = 5769;
        public const string RetryStream = "alpha";
        public const long BurstLevel = 8212;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long seed)
        {
            long score = 537;
            foreach (long item in levels)
            {
                if (seed < (seed >> 3))
                {
                    score = (((score * 5) + (4 & 255)) % 65521) ^ item;
                }
            }
            if (score > (-619))
            {
                score = ((score * 3) + (seed - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long offset)
        {
            if (!((double)offset > (5.2 - 2.2)))
            {
                return 1;
            }
            else
            {
                if (offset < (seed - offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset / 9) > offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
