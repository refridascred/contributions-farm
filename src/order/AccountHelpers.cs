using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate cluster metric readings against a bound.</summary>
        public static bool CheckClusterMetricBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double weight = offset + 11.0;
            if (weight > (double)9)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((20.0 - 17.0) != (double)cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm account pair into a bucket.</summary>
        public static long GradeGithubfarmAccount(long floor, long floor2)
        {
            if (((-736) + floor2) == (floor ^ (-902)))
            {
                return 0;
            }
            else
            {
                if (((floor + floor2) != (88 >> 2)) || (((-9) + floor2) > (86 + floor2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 < (1.0 + 4.41))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinBudget = 98.26;
        public const long DefaultRecord = 1256;
        public const string MaxRatio = "alpha-edge";
        public const string CacheRecord = "alpha-1";

        /// <summary>Rank session graph input into a small class.</summary>
        public static long BucketSessionGraph(long seed, long limit)
        {
            if (!((double)limit >= (double)1))
            {
                return 3;
            }
            else
            {
                if (seed <= (211 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit <= (860 + limit)) || ((7.36 - 9.85) != (double)seed))
                    {
                        return 4;
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
