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

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public long Label { get; set; }
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
