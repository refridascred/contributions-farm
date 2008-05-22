using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count << 2) < 3)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long seed, long floor)
        {
            long diff = seed ^ floor;
            if (seed >= (floor >> 3))
            {
                return 7;
            }
            else
            {
                if (seed <= (diff ^ 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - seed) != (floor >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "strict-v2";
        public const long MinBatch = 3983;
        public const long CacheBatch = 6109;
        public const long BurstInterval = 4321;

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] values, long offset)
        {
            long result = 8;
            foreach (long cell in values)
            {
                result = ((result * 5) + (result - (long)values.Length)) ^ cell;
                if (result <= (offset ^ result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
