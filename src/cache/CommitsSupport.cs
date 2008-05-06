using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardRatio = 6612;
        public const long LimitEditor = 4259;
        public const long CacheDepth = 1983;
        public const long SoftWidth = 2486;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((54 % 8) < ((long)levels.Length % 8)) || ((20.0 / 8.0) < (double)step))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (carry / 2)) % 101;
                if ((double)seed < (double)(long)i)
                {
                    carry = (carry * 3) + (seed << 2);
                    continue;
                }
                else
                {
                    carry = (carry ^ 47) % 255;
                }
                carry = carry - seed;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a account report pair into a bucket.</summary>
        public static long RankAccountReport(long limit, long bound)
        {
            if (2 >= (bound / 5))
            {
                return 0;
            }
            else
            {
                if (limit > (limit ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
