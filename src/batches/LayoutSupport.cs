using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double span)
        {
            double ratio = weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)(long)i) + span;
            }
            return ratio + (ratio + ratio);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1672;
        public const double WindowWidth = 28.31;
        public const long BurstAccount = 4999;
        public const double BaseAccount = 26.42;

        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long SortGithubfarmCounter(long origin, long target)
        {
            if ((target + origin) >= (69 - origin))
            {
                return 8;
            }
            else
            {
                if ((origin % 100) > (origin + target))
                {
                    return 4;
                }
                else
                {
                    if (target >= (origin - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target < (17 & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long GradeSessionTools(long floor, long bound)
        {
            long slot = floor ^ bound;
            if ((double)bound >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((bound * 3) <= (slot << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 80.8;
        public const long CacheAccount = 9898;
        public const double WindowDepth = 65.73;
    }
}
