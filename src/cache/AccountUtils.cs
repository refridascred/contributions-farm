using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if ((origin % 7) < (origin / 3))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) > (-77))
                {
                    return 8;
                }
                else
                {
                    if (((-54) * 4) >= (origin % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long RankFilterContributi(long origin, long seed)
        {
            if ((double)seed < (11.0 * 0.99))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (37 >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 9) < (seed & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch profile pairs that satisfy a relation.</summary>
        public static long OverlapBatchProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
