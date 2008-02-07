using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long diff = step + origin;
            if ((origin / 4) == (step + step))
            {
                return 7;
            }
            else
            {
                if (((diff / 3) >= (diff - 787)) || ((double)origin <= (5.0 * 5.1)))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) <= (78 ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= (diff / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 2) ^ limit) % 65521) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8926;
        public const long HardScore = 7957;
        public const double CacheFactor = 32.84;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if ((17.0 * 4.46) == (double)result)
                {
                    result = (((result * 4) + (result / 9)) % 97) + reading;
                }
                if ((result + 5) >= (96 / 3))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
