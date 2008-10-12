using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long diff = step ^ step2;
            if ((step2 ^ step2) != (diff - (-929)))
            {
                return 7;
            }
            else
            {
                if ((double)diff > (4.2 - 4.5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 12) <= (cell + 235))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long target, long origin)
        {
            long step = target - origin;
            if ((origin / 2) >= 3)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= target)
                {
                    return 6;
                }
                else
                {
                    if (!((6.11 / 6.0) == (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (35 > (origin << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a format farm sample.</summary>
        public static long SeekFormatFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
